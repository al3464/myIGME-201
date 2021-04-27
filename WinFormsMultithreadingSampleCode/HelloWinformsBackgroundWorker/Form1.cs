using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace HelloWinformsBackgroundWorker
{
	public partial class Form1 : Form
	{
		private readonly BackgroundWorker worker;

		public Form1()
		{
			InitializeComponent();

			worker = new BackgroundWorker();
			worker.WorkerReportsProgress = true;
			worker.DoWork += StartCounting;
			worker.ProgressChanged += worker_ProgressChanged;
			worker.RunWorkerCompleted += worker_RunWorkerCompleted;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			worker.RunWorkerAsync();
			button1.Enabled = false;
		}

		private void StartCounting(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker bgWorker = (BackgroundWorker) sender;
			for (var i = 0; i < 10; i++)
			{
				bgWorker.ReportProgress(i);
				Thread.Sleep(1000);
			}
		}

		private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			textBox1.Text = e.ProgressPercentage.ToString();
		}

		void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			button1.Enabled = true;
		}
	}
}
