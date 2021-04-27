using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_UnitTest3Q3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            backButton.Click += new EventHandler(BackButton__Click);
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            this.timer1.Tick += new EventHandler(Timer__Tick);
            timer1.Interval = 1000;
            pictureBox1.Click += new EventHandler(PictureBox1__Click);
        }

        private void BackButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
        private void PictureBox1__Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            if (radioButton1.Checked)
            {
                webBrowser1.Navigate("https://www.cnn.com/2021/04/26/health/blood-clots-johnson-johnson-vaccine-wellness/index.html");
            }
            else if (radioButton2.Checked)
            {
                webBrowser1.Navigate("https://theconversation.com/people-with-severe-allergies-warned-off-pfizer-covid-vaccine-for-now-but-that-may-change-as-more-details-emerge-151837");
            }
            else
            {
                webBrowser1.Navigate("https://www.pbs.org/newshour/health/the-powerful-technology-behind-the-pfizer-and-moderna-vaccines");
            }
            
        }

        Bitmap img1 = Properties.Resources.Johnson___Johnson_COVID_19_vaccine_developed_by_Janssen;
        Bitmap img2 = Properties.Resources._2021_03_15T095921Z_1480341943_RC2LBM9T54M3_RTRMADP_3_HEALTH_CORONAVIRUS_MRNA_e1617398931565_1024x647;
        Bitmap img3 = Properties.Resources.file_20201210_13_1br3gai;


        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Johnson_%26_Johnson_COVID-19_vaccine");
            groupBox1.Text = "Johnson";
            pictureBox1.Image = img1;
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Pfizer%E2%80%93BioNTech_COVID-19_vaccine");
            groupBox1.Text = "Pfizer";
            pictureBox1.Image = img2;
            this.timer1.Start();
        }
        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://en.wikipedia.org/wiki/Moderna_COVID-19_vaccine");
            groupBox1.Text = "Moderna";
            pictureBox1.Image = img3;
        }


    }
}
