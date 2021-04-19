using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ArcherLai_PE27
{
    public delegate void UpdateConversationDelegate(string text);

    public partial class DyscordForm : Form
    {
        string targetUser;
        string targetIp;
        int targetPort;
        string myIp;
        int myPort = 2222;
        Thread thread;
        Socket listener;
        public DyscordForm()
        {
            InitializeComponent();
            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort);
            settingsForm.ShowDialog();
            this.myPort = settingsForm.myPort;

            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            ThreadStart threadStart1 = new ThreadStart(Listen);
            thread = new Thread(threadStart1);
            thread.Start();

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress iPAddress in ipHost.AddressList)
            {
                if(IPAddress.AddressFamily = AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }

            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.usersButton.Click += new EventHandler(UsersButton__Click);
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            if(userTextBox.TextLength > 0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=" + userTextBox.Text + "&ip=" + myIp + ":"+ myPort);
                webBrowser1.Visible = false;
                userTextBox.Enabled = false;
                loginButton.Enabled = false;           
            }
        }

        private void UsersButton__Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();
            
        }

        private void WebBrowser1__DocumentCompleted(object sender, EventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach(HtmlElement htmlElement in htmlElementCollection)
            {

            }
        }

        private void SendButton__Click(object sender, EventArgs e)
        {

        }

        private void ExitButton__Click(object sender, EventArgs e)
        {

        }


        public void updateConversation(string text)
        {
            this.convRichTextBox.Text += text + "\n";
        }

        public void Listen()
        {
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(updateConversation);

            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, this.myPort);

            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            listener.Bind(serverEndpoint);
            listener.Listen(300);
            while (true)
            {
                Socket client = listener.Accept();
                Stream netStream = new NetworkStream(client);
                StreamReader reader = new StreamReader(netStream);
                string result = reader.ReadToEnd();
                Invoke(updateConversationDelegate, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }

        }
    }
}
