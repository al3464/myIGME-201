using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_Extracredit2
{
    public partial class Form1 : Form
    {  
       
              
        public Form1()
        {
            InitializeComponent();
            this.timer1.Tick += new EventHandler(Timer__Tick);
            timer1.Interval = 1000;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            label4.Visible = false;
            nameText.KeyPress += new KeyPressEventHandler(nameText__KeyPress);
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            textBox1.KeyPress += new KeyPressEventHandler(textBox1__KeyPress);
            pictureBox1.Visible = false;

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if(progressBar1.Value == 100)
            {
                pictureBox1.Visible = true;
            }
            
        }

        private void nameText__KeyPress(object sender, EventArgs e)
        {
            this.timer1.Start();
            groupBox1.Visible = true;
        }

        private void textBox1__KeyPress(object sender, EventArgs e)
        {

            if (textBox1.Text == "10")
            {
                label4.Visible = true;
                label4.Text = "Correct!!" + nameText.Text + "!!";
            }
            else
            {
                label4.Visible = false;
            }
        }


        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            panel1.Visible = true;
            Qone.Visible = true;
            Qtwo.Visible = false;
            Qthree.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;         
            textBox3.Visible = false;
            Random random = new Random();
            int num1 = random.Next(50);
            Qone.Text = num1 + "+" + num1 + "=";
            string s = num1.ToString();
   

        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {


        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
