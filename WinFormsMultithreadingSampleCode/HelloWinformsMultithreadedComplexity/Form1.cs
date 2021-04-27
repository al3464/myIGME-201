using System;
using System.Windows.Forms;
using System.Threading;

namespace HelloWinformsMultithreadedComplexity
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
			button1.Enabled = false;
		}

		private delegate void DisplayCountDelegate(int i);
		private delegate void EnableButtonDelegate();

		private void StartCounting()
		{
			for (var i = 0; i < 10; i++)
			{
				textBox1.Invoke(new DisplayCountDelegate(DisplayCount), i);
				Thread.Sleep(1000);
			}
			button1.Invoke(new EnableButtonDelegate(EnableButton));
		}

		private void EnableButton()
		{
			button1.Enabled = true;
		}

		private void DisplayCount(int i)
		{
			textBox1.Text = i.ToString();
		}
	}
}
