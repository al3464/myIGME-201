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
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ArcherLai_UnitTest3Q3
{
    public partial class Form3 : Form
    {


        public Form3()
        {
           

        }



        private void HeavyOperation()
        {

            for (int i = 0; i <= 10; i++)
            {

                if (!this.stopProcess)
                {

                    this.Invoke(this.updateStatusDelegate);
                }
                else
                {

                    this.workerThread.Abort();
                }
            }
        }

        private Thread workerThread = null;

        private bool stopProcess = false;

        private void BtnStart__Click(object sender, EventArgs e)
        {
            this.stopProcess = false;
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperation));
            this.workerThread.Start();
        }


        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;

        private void Form3_Load(object sender, EventArgs e)
        {

            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
        }

        private void UpdateStatus()
        {
            this.textBox1.Text += "*";
        }

        private void BtnStop__Click(object sender, EventArgs e)
        {
            this.stopProcess = true;
        }

    }
}
