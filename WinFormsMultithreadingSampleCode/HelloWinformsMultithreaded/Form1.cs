using System.Windows.Forms;
using System.Threading;

namespace HelloWinformsMultithreaded
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			var thread = new Thread(StartCounting);
			thread.IsBackground = true;
			thread.Start();
		}

		private void StartCounting()
		{
			for (var i = 0; i < 10; i++)
			{
				textBox1.Text = i.ToString();
				Thread.Sleep(1000);
			}
		}
	}
}
