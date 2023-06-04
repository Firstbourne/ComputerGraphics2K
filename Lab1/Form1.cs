using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters invertFilter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(invertFilter);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
                image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void onXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter_X();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void onYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter_Y();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpeningFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void onXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new BorderHighlighting_X();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void onYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new BorderHighlighting_Y();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorld(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void linearCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearCorrection(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new RotateFilter(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MoveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void waveFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WaveFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MedianFilter(3);
            backgroundWorker1.RunWorkerAsync(filter);
        }
    }
}
