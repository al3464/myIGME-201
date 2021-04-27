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

        }
        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.worldometers.info/coronavirus/country/uk/");
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }

        private void RadioButton4__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");

        }

        private void RadioButton5__CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }

        private void RadioButton6__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
