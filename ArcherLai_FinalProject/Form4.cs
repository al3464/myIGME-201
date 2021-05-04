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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            button1.Click += new EventHandler(Button1__Click);
        }

        private void Button1__Click(object sender, EventArgs e)
        {
            Form2 oFrm2 = new Form2();
            oFrm2.Show();
        }
    }
}
