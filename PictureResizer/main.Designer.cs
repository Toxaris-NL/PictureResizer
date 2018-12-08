namespace PictureResizer {
    partial class main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuslity = new System.Windows.Forms.Label();
            this.btnResize = new System.Windows.Forms.Button();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.tbQuality = new System.Windows.Forms.TrackBar();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(375, 269);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 30);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(20, 88);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(98, 17);
            this.lblOriginal.TabIndex = 2;
            this.lblOriginal.Text = "Original Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuslity
            // 
            this.lblQuslity.AutoSize = true;
            this.lblQuslity.Location = new System.Drawing.Point(14, 32);
            this.lblQuslity.Name = "lblQuslity";
            this.lblQuslity.Size = new System.Drawing.Size(52, 17);
            this.lblQuslity.TabIndex = 5;
            this.lblQuslity.Text = "Quality";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(375, 318);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(120, 30);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.pictureBox1);
            this.gbPreview.Location = new System.Drawing.Point(585, 12);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(331, 438);
            this.gbPreview.TabIndex = 7;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Current Size";
            // 
            // tbQuality
            // 
            this.tbQuality.Location = new System.Drawing.Point(72, 30);
            this.tbQuality.Maximum = 100;
            this.tbQuality.Minimum = 50;
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(423, 56);
            this.tbQuality.TabIndex = 8;
            this.tbQuality.Value = 50;
            this.tbQuality.ValueChanged += new System.EventHandler(this.tbQuality_ValueChanged);
            // 
            // numQuality
            // 
            this.numQuality.Location = new System.Drawing.Point(501, 30);
            this.numQuality.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(52, 22);
            this.numQuality.TabIndex = 9;
            this.numQuality.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numQuality.ValueChanged += new System.EventHandler(this.numQuality_ValueChanged);
            // 
            // tbOriginal
            // 
            this.tbOriginal.Enabled = false;
            this.tbOriginal.Location = new System.Drawing.Point(124, 88);
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(429, 22);
            this.tbOriginal.TabIndex = 10;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(124, 127);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(429, 22);
            this.tbTarget.TabIndex = 12;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(27, 127);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(91, 17);
            this.lblTarget.TabIndex = 11;
            this.lblTarget.Text = "Target Name";
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(124, 165);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(82, 22);
            this.tbFileSize.TabIndex = 14;
            this.tbFileSize.Validating += new System.ComponentModel.CancelEventHandler(this.tbFileSize_Validating);
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(37, 168);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(81, 17);
            this.lblFileSize.TabIndex = 13;
            this.lblFileSize.Text = "Target Size";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(212, 168);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(24, 17);
            this.lblEntity.TabIndex = 15;
            this.lblEntity.Text = "kB";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 462);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.tbFileSize);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.tbOriginal);
            this.Controls.Add(this.numQuality);
            this.Controls.Add(this.tbQuality);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.lblQuslity);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Toxaris Picture Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuslity;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.TrackBar tbQuality;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblEntity;
    }
}

