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

namespace ArcherLai_UnitTest3Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(RadioButton4__CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(RadioButton5__CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(RadioButton6__CheckedChanged);
            vaccineButton.Click += new EventHandler(VaccineButton__Click);
            exitButton.Click += new EventHandler(ExitButton__Click);
            searchButton.Click += new EventHandler(SearchButton__Click);
        }

        

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void VaccineButton__Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/us/");
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/uk/");
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/china/");
        }

        private void RadioButton4__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/france/");

        }

        private void RadioButton5__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/italy/");
        }

        private void RadioButton6__CheckedChanged(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://people.rit.edu/al3464/235/hello/hello.html");
            
        }

        private void SearchButton__Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/"+textBox1.Text+"/");
        }


    }
}
