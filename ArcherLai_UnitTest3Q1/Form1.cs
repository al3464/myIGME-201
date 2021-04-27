using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_UnitTest3Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            allButton.CheckedChanged += new EventHandler(AllButton__CheckedChanged);
            repulblicanButton.CheckedChanged += new EventHandler(RepublicanButton__CheckedChanged);
            democratButton.CheckedChanged += new EventHandler(DemocratButton__CheckedChanged);
            drButton.CheckedChanged += new EventHandler(DrButton__CheckedChanged);
            federalistButton.CheckedChanged += new EventHandler(FederalistButton__CheckedChanged);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
           
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
        }

        private void AllButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
        }

        private void RepublicanButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
        }

        private void DemocratButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton5.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
        }

        private void DrButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
        }

        private void FederalistButton__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
        }
    }
}
