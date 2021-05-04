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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listBox1.Visible = false;
            button1.Click += new EventHandler(Button1__Click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Button1__Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
