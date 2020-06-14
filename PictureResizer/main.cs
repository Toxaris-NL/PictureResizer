using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PictureResizer
{
    public partial class main : Form
    {
        internal Photo photo;
        private Quality quality = new Quality();

        public main()
        {
            InitializeComponent();

            quality.Value = 90;
            tbFileSize.Text = "1000";
            tbQuality.DataBindings.Add("Value", quality, "Value");
            numQuality.DataBindings.Add("Value", quality, "Value");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg; *.jpeg",
                Title = "Select file",
                CheckFileExists = true
            };
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                photo = new Photo(Image.FromFile(fileOpen.FileName));
                photo.SetSourceInfo(fileOpen.FileName);
                tbOriginal.Text = fileOpen.FileName;
                tbTarget.Text = support.CreateTargetFilename(fileOpen.FileName);
                int fileSize = (int)(new FileInfo(fileOpen.FileName).Length / 1024);
                gbPreview.Text = string.Format("Current size: {0} kB", fileSize);
            }

            if (photo != null)
            {
                pictureBox1.Image = photo.originalPhoto;
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            photo.SetAllowedFileSize(Convert.ToInt32(tbFileSize.Text));
            photo.SetQuality(quality.Value);
            photo.ScalePhoto();

            SaveFileDialog fileSave = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "jpg",
                Filter = "Image (*.jpg)|*.jpg",
                InitialDirectory = Path.GetDirectoryName(tbTarget.Text),
                FileName = Path.GetFileName(tbTarget.Text)
            };
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                photo.SaveFile(fileSave.FileName);
                MessageBox.Show("File saved.", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbQuality_ValueChanged(object sender, EventArgs e)
        {
            quality.Value = tbQuality.Value;

            if (photo != null) { photo.SetQuality(quality.Value); }
        }

        private void numQuality_ValueChanged(object sender, EventArgs e)
        {
            quality.Value = (int)numQuality.Value;

            if (photo != null) { photo.SetQuality(quality.Value); }
        }

        private void tbFileSize_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!support.ValidInteger(tbFileSize.Text, out errorMessage))
            {
                // Cancel the event and select the text to be corrected by the user.
                MessageBox.Show(errorMessage);
                e.Cancel = true;
                tbFileSize.Select(0, tbFileSize.Text.Length);
            }
        }

        private void btnBatch_Click(object sender, EventArgs e)
        {
            using (Form batch = new batchForm())
            {
                batch.ShowDialog();
            }
        }
    }
}