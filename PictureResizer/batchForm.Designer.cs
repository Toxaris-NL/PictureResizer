namespace PictureResizer
{
    partial class batchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batchForm));
            this.lblEntity = new System.Windows.Forms.Label();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.tbQuality = new System.Windows.Forms.TextBox();
            this.lblQuality = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntity
            // 
            this.lblEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(187, 406);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(24, 17);
            this.lblEntity.TabIndex = 21;
            this.lblEntity.Text = "kB";
            // 
            // tbFileSize
            // 
            this.tbFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFileSize.Location = new System.Drawing.Point(99, 403);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(82, 22);
            this.tbFileSize.TabIndex = 20;
            this.tbFileSize.Validating += new System.ComponentModel.CancelEventHandler(this.IntegerValidating);
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(12, 406);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(81, 17);
            this.lblFileSize.TabIndex = 19;
            this.lblFileSize.Text = "Target Size";
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.Location = new System.Drawing.Point(12, 12);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.RowTemplate.Height = 24;
            this.dgvBatch.Size = new System.Drawing.Size(969, 348);
            this.dgvBatch.TabIndex = 22;
            this.dgvBatch.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBatch_CellFormatting);
            this.dgvBatch.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvBatch_CellValidating);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(704, 398);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(109, 33);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "Select File(s)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(872, 398);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(109, 33);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Process";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnDir
            // 
            this.btnDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDir.Location = new System.Drawing.Point(563, 398);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(122, 33);
            this.btnDir.TabIndex = 25;
            this.btnDir.Text = "Select Directory";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(428, 406);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage.TabIndex = 28;
            this.lblPercentage.Text = "%";
            this.lblPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.IntegerValidating);
            // 
            // tbQuality
            // 
            this.tbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbQuality.Location = new System.Drawing.Point(387, 403);
            this.tbQuality.Name = "tbQuality";
            this.tbQuality.Size = new System.Drawing.Size(37, 22);
            this.tbQuality.TabIndex = 27;
            // 
            // lblQuality
            // 
            this.lblQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(283, 406);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(98, 17);
            this.lblQuality.TabIndex = 26;
            this.lblQuality.Text = "Target Quality";
            // 
            // batchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 457);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.tbQuality);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvBatch);
            this.Controls.Add(this.lblEntity);
            this.Controls.Add(this.tbFileSize);
            this.Controls.Add(this.lblFileSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "batchForm";
            this.Text = "Batch process";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox tbQuality;
        private System.Windows.Forms.Label lblQuality;
    }
}