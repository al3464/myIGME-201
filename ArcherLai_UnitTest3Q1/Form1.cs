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

            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(RadioButton4__CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(RadioButton5__CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(RadioButton6__CheckedChanged);
            radioButton7.CheckedChanged += new EventHandler(RadioButton7__CheckedChanged);
            radioButton8.CheckedChanged += new EventHandler(RadioButton8__CheckedChanged);
            radioButton9.CheckedChanged += new EventHandler(RadioButton9__CheckedChanged);
            radioButton10.CheckedChanged += new EventHandler(RadioButton10__CheckedChanged);
            radioButton11.CheckedChanged += new EventHandler(RadioButton11__CheckedChanged);
            radioButton12.CheckedChanged += new EventHandler(RadioButton12__CheckedChanged);
            radioButton13.CheckedChanged += new EventHandler(RadioButton13__CheckedChanged);
            radioButton14.CheckedChanged += new EventHandler(RadioButton14__CheckedChanged);
            radioButton15.CheckedChanged += new EventHandler(RadioButton15__CheckedChanged);
            radioButton16.CheckedChanged += new EventHandler(RadioButton16__CheckedChanged);

            allButton.CheckedChanged += new EventHandler(AllButton__CheckedChanged);
            repulblicanButton.CheckedChanged += new EventHandler(RepublicanButton__CheckedChanged);
            democratButton.CheckedChanged += new EventHandler(DemocratButton__CheckedChanged);
            drButton.CheckedChanged += new EventHandler(DrButton__CheckedChanged);
            federalistButton.CheckedChanged += new EventHandler(FederalistButton__CheckedChanged);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);
            this.timer1.Tick += new EventHandler(Timer__Tick);
            timer1.Interval = 1000;
            textBox1.KeyPress += new KeyPressEventHandler(TextBox1__KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(TextBox2__KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(TextBox3__KeyPress);
            textBox4.KeyPress += new KeyPressEventHandler(TextBox4__KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(TextBox5__KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(TextBox6__KeyPress);
            textBox7.KeyPress += new KeyPressEventHandler(TextBox7__KeyPress);
            textBox8.KeyPress += new KeyPressEventHandler(TextBox8__KeyPress);
            textBox9.KeyPress += new KeyPressEventHandler(TextBox9__KeyPress);
            textBox10.KeyPress += new KeyPressEventHandler(TextBox10__KeyPress);
            textBox11.KeyPress += new KeyPressEventHandler(TextBox11__KeyPress);
            textBox12.KeyPress += new KeyPressEventHandler(TextBox12__KeyPress);
            textBox13.KeyPress += new KeyPressEventHandler(TextBox13__KeyPress);
            textBox14.KeyPress += new KeyPressEventHandler(TextBox14__KeyPress);
            textBox15.KeyPress += new KeyPressEventHandler(TextBox15__KeyPress);
            textBox16.KeyPress += new KeyPressEventHandler(TextBox16__KeyPress);
            
        }
        

        




        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        Bitmap img1 = Properties.Resources.BenjaminHarrison;
        Bitmap img2 = Properties.Resources.FranklinDRoosevelt;
        Bitmap img3 = Properties.Resources.WilliamJClinton;
        Bitmap img4 = Properties.Resources.JamesBuchanan;
        Bitmap img5 = Properties.Resources.FranklinPierce;
        Bitmap img6 = Properties.Resources.GeorgeWBush;
        Bitmap img7 = Properties.Resources.BarackObama;
        Bitmap img8 = Properties.Resources.JohnFKennedy;
        Bitmap img9 = Properties.Resources.ThomasJefferson;
        Bitmap img10 = Properties.Resources.TheodoreRoosevelt;
        Bitmap img11 = Properties.Resources.JohnAdams;
        Bitmap img12 = Properties.Resources.GeorgeWashington;
        Bitmap img13 = Properties.Resources.MartinVanBuren;
        Bitmap img14 = Properties.Resources.DwightDEisenhower;
        Bitmap img15 = Properties.Resources.RonaldReagan;
        Bitmap img16 = Properties.Resources.WilliamMcKinley;


        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
           
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void PictureBox1__MouseMove()
        {

        }



        private void AllButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = true;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;
        }

        private void RepublicanButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = true;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = true;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = true;
            radioButton15.Visible = true;
            radioButton16.Visible = true;
           
        }

        private void DemocratButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = false;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = true;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
        }

        private void DrButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = true;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
        }

        private void FederalistButton__CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img1;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img2;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
            
               
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img3;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
        }

        private void RadioButton4__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img4;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
        }

        private void RadioButton5__CheckedChanged(object sender, EventArgs e)
            
        {
            pictureBox1.Image = img5;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
        }

        private void RadioButton6__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img6;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";

        }

        private void RadioButton7__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img7;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";

        }

        private void RadioButton8__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img8;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
        }

        private void RadioButton16__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img16;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
        }

        private void RadioButton15__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img15;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
        }

        private void RadioButton14__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img14;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
        }

        private void RadioButton13__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img13;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
        }

        private void RadioButton12__CheckedChanged(object sender, EventArgs e)
        {
                pictureBox1.Image = img12;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
        }

        private void RadioButton11__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img11;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
        }

        private void RadioButton10__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img10;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
        }

        private void RadioButton9__CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img9;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            groupBox1.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
            if(textBox1.Text == "1")
            {
                notifyIcon1.Visible = false;
            }
            else
            {
                notifyIcon1.Visible = true;
            }
        }

        private void TextBox2__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void TextBox3__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void TextBox4__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox5__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void TextBox6__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox7__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox8__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox9__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox10__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox11__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox12__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox13__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox14__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox15__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
        private void TextBox16__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
            
        }
    }
}
