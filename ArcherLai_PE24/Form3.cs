﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherLai_PE24
{
    public partial class ImageForm : Form
    {
        string title;
        public ImageForm(GifFinder parent, string url, string title)
        {
            InitializeComponent();

            this.MdiParent = parent;
            this.Text = title;
            this.title = title;

            parent.closeAllToolStripMenuItem.Click += new EventHandler(CloseAllToolStripMenuItem__Click);
            parent.saveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem__Click);

            this.FormClosing += new FormClosingEventHandler(ImageForm_FormClosing);
            pictureBox1.ImageLocation = url;
        }

        private void CloseAllToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageForm_FormClosing(object sender, EventArgs e)
        {
            GifFinder parent = (GifFinder)this.MdiParent;
            parent.closeAllToolStripMenuItem.Click -= new EventHandler(CloseAllToolStripMenuItem__Click);
            parent.saveToolStripMenuItem.Click -= new EventHandler(SaveToolStripMenuItem__Click);
        }

        private void SaveToolStripMenuItem__Click(object sender, EventArgs e)
        {
            if(this != this.MdiParent.ActiveMdiChild)
            {
                return;
            }
            saveFileDialog1.Filter = "Bmp(*.BMP)|*.BMP|Jpg(*.JPG)|*.JPG|Png(*.PNG)|*.PNG|Gif(*.GIF)|*.GIF";
            saveFileDialog1.FileName = this.title;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
