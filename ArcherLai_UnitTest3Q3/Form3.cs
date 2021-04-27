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
            
            listenButton.Click += new EventHandler(ListenButton__Click);

        }



        private void HeavyOperation()
        {
            // Example heavy operation
            for (int i = 0; i <= 999999; i++)
            {
                // Check if Stop button was clicked
                if (!this.stopProcess)
                {
                    // Show progress
                    this.Invoke(this.updateStatusDelegate);
                }
                else
                {
                    // Stop heavy operation
                    this.workerThread.Abort();
                }
            }
        }

        // Declare our worker thread
        private Thread workerThread = null;

        // Boolean flag used to stop the 
        private bool stopProcess = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.stopProcess = false;

            // Initialise and start worker thread
            this.workerThread = new Thread(new ThreadStart(this.HeavyOperation));
            this.workerThread.Start();
        }

        // Declare a delegate used to communicate with the UI thread
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;

        private void Form3_Load(object sender, EventArgs e)
        {
            // Initialise the delegate
            this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
        }

        private void UpdateStatus()
        {
            this.txtProgress.Text += "*";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.stopProcess = true;
        }

    }
}
