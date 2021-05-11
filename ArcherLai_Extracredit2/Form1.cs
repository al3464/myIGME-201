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
            label4.Visible = false;
            label7.Visible = false;
            nameText.KeyPress += new KeyPressEventHandler(nameText__KeyPress);
            radioButton1.CheckedChanged += new EventHandler(RadioButton1__CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton2__CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton3__CheckedChanged);
            textBox1.KeyPress += new KeyPressEventHandler(textBox1__KeyPress);
            textBox1.KeyPress += new KeyPressEventHandler(textBox2__KeyPress);
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

            if (textBox1.Text == "41")
            {
                label4.Visible = true;
                label4.Text = "Correct!!" + nameText.Text + "!!";
                Qtwo.Visible = true;
                textBox2.Visible = true;
                Qtwo.Text = "20 + 45 =";
            }
            if (textBox1.Text != "41")
            {
                label7.Visible = true;
            }


        }

        private void textBox2__KeyPress(object sender, EventArgs e)
        {
            if(textBox2.Text == "65")
            {
                label7.Visible = false;
                label4.Visible = true;
                label4.Text = "You finished!" + nameText.Text + "!!";
            }
        }

        private void RadioButton1__CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            panel1.Visible = true;
            Qone.Visible = true;
            Qtwo.Visible = false;

            textBox1.Visible = true;
            textBox2.Visible = false;         

            Random random = new Random();
            int num1 = random.Next(50);
            Qone.Text = "11 + 30 =";
   

        }

        private void RadioButton2__CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            panel2.Visible = true;
            Qfour.Visible = true;
            Qfive.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = false;
            Qseven.Visible = false;
            Qeight.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            Qfour.Text = "100 x 80 =";
        }

        private void RadioButton3__CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            panel2.Visible = true;
            Qseven.Visible = true;
            Qfour.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            Qfive.Visible = false;
            Qeight.Visible = false;
            textBox7.Visible = true;
            textBox8.Visible = false;
            Qseven.Text = "90 / 30 x 2 =";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
