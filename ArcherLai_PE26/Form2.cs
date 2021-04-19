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
using System.Net.Sockets;
using System.IO;

namespace ArcherLai_PE27
{
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
        }

        public void Listen()
        {
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, this.myPort);
            this.listener = new Socket(AddressFamily.InterNetwork, Socket.Stream, ProtocolType.Tcp);


        }
    }
}
