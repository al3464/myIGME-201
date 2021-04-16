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
    public partial class TigerMatch : Form
    {
        public TigerMatch()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 oFrm2 = new Form2();
            oFrm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 oFrm3 = new Form3();
            oFrm3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 oFrm4 = new Form4();
            oFrm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 oFrm5 = new Form5();
            oFrm5.Show();
        }

        private void TigerMatch_Load(object sender, EventArgs e)
        {

        }
    }
}
