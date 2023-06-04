
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movingFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderHighlightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancel = new System.Windows.Forms.Button();
            this.waveFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointedToolStripMenuItem,
            this.matrixToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // pointedToolStripMenuItem
            // 
            this.pointedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.grayWorldToolStripMenuItem,
            this.linearCorrectionToolStripMenuItem,
            this.movingFilterToolStripMenuItem,
            this.waveFilterToolStripMenuItem});
            this.pointedToolStripMenuItem.Name = "pointedToolStripMenuItem";
            this.pointedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pointedToolStripMenuItem.Text = "Pointed";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // grayWorldToolStripMenuItem
            // 
            this.grayWorldToolStripMenuItem.Name = "grayWorldToolStripMenuItem";
            this.grayWorldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayWorldToolStripMenuItem.Text = "Gray World";
            this.grayWorldToolStripMenuItem.Click += new System.EventHandler(this.grayWorldToolStripMenuItem_Click);
            // 
            // linearCorrectionToolStripMenuItem
            // 
            this.linearCorrectionToolStripMenuItem.Name = "linearCorrectionToolStripMenuItem";
            this.linearCorrectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linearCorrectionToolStripMenuItem.Text = "Linear Correction";
            this.linearCorrectionToolStripMenuItem.Click += new System.EventHandler(this.linearCorrectionToolStripMenuItem_Click);
            // 
            // movingFilterToolStripMenuItem
            // 
            this.movingFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripMenuItem,
            this.rotateToolStripMenuItem});
            this.movingFilterToolStripMenuItem.Name = "movingFilterToolStripMenuItem";
            this.movingFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movingFilterToolStripMenuItem.Text = "Moving Filter";
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.sharpeningToolStripMenuItem,
            this.borderHighlightingToolStripMenuItem,
            this.medianFilterToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.matrixToolStripMenuItem.Text = "Matrix";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onXToolStripMenuItem,
            this.onYToolStripMenuItem});
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            // 
            // onXToolStripMenuItem
            // 
            this.onXToolStripMenuItem.Name = "onXToolStripMenuItem";
            this.onXToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.onXToolStripMenuItem.Text = "on_X";
            this.onXToolStripMenuItem.Click += new System.EventHandler(this.onXToolStripMenuItem_Click);
            // 
            // onYToolStripMenuItem
            // 
            this.onYToolStripMenuItem.Name = "onYToolStripMenuItem";
            this.onYToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.onYToolStripMenuItem.Text = "on_Y";
            this.onYToolStripMenuItem.Click += new System.EventHandler(this.onYToolStripMenuItem_Click);
            // 
            // sharpeningToolStripMenuItem
            // 
            this.sharpeningToolStripMenuItem.Name = "sharpeningToolStripMenuItem";
            this.sharpeningToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sharpeningToolStripMenuItem.Text = "Sharpening";
            this.sharpeningToolStripMenuItem.Click += new System.EventHandler(this.sharpeningToolStripMenuItem_Click);
            // 
            // borderHighlightingToolStripMenuItem
            // 
            this.borderHighlightingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onXToolStripMenuItem1,
            this.onYToolStripMenuItem1});
            this.borderHighlightingToolStripMenuItem.Name = "borderHighlightingToolStripMenuItem";
            this.borderHighlightingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.borderHighlightingToolStripMenuItem.Text = "Border Highlighting";
            // 
            // onXToolStripMenuItem1
            // 
            this.onXToolStripMenuItem1.Name = "onXToolStripMenuItem1";
            this.onXToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.onXToolStripMenuItem1.Text = "on_X";
            this.onXToolStripMenuItem1.Click += new System.EventHandler(this.onXToolStripMenuItem1_Click);
            // 
            // onYToolStripMenuItem1
            // 
            this.onYToolStripMenuItem1.Name = "onYToolStripMenuItem1";
            this.onYToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.onYToolStripMenuItem1.Text = "on_Y";
            this.onYToolStripMenuItem1.Click += new System.EventHandler(this.onYToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 447);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(648, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(671, 447);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(71, 19);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // waveFilterToolStripMenuItem
            // 
            this.waveFilterToolStripMenuItem.Name = "waveFilterToolStripMenuItem";
            this.waveFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waveFilterToolStripMenuItem.Text = "Wave Filter";
            this.waveFilterToolStripMenuItem.Click += new System.EventHandler(this.waveFilterToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medianFilterToolStripMenuItem.Text = "Median Filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 480);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderHighlightingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem onYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grayWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movingFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waveFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
    }
}

