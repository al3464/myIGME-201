using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            okButton.Visible = false;
            single.CheckedChanged += new EventHandler(Single__CheckedChanged);
            standard.CheckedChanged += new EventHandler(Standard__CheckedChanged);
            triple.CheckedChanged += new EventHandler(Triple__CheckedChanged);
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            okButton.Click += new EventHandler(OkButton__Click);
        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "Greenwood Cove";
            theHill.Text = "The hill";
            theLodge.Text = "The lodge";
        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "House1";
            theHill.Text = "House2";
            theLodge.Text = "House3";
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            greenWood.Text = "Sol Heumann Hall";
            theHill.Text = "Helen Fish Hall";
            theLodge.Text = "Mark Ellingson Hall";
        }

        private void OkButton__Click(object sender, EventArgs e)
        {
            Form3 oFrm3 = new Form3();
            oFrm3.Show();

        }

        private void Single__CheckedChanged(object sender, EventArgs e)
        {
            okButton.Visible = true;
        }

        private void Standard__CheckedChanged(object sender, EventArgs e)
        {
            okButton.Visible = true;
        }

        private void Triple__CheckedChanged(object sender, EventArgs e)
        {
            okButton.Visible = true;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
