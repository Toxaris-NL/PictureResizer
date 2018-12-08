using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureResizer {
    public partial class main : Form {
        internal Photo photo;
        Quality quality = new Quality();

        public main() {
            InitializeComponent();
            
            quality.Value = 90;
            tbFileSize.Text = "1000";
            tbQuality.DataBindings.Add("Value", quality, "Value");
            numQuality.DataBindings.Add("Value", quality, "Value");
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "Image Files|*.jpg; *.jpeg";
            fileOpen.Title = "Select file";
            fileOpen.CheckFileExists = true;
            if(fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                photo = new Photo(Image.FromFile(fileOpen.FileName));
                photo.SetSourceInfo(fileOpen.FileName);
                tbOriginal.Text = fileOpen.FileName;
                tbTarget.Text = CreateTargetFilename(fileOpen.FileName);
                int fileSize = (int)(new FileInfo(fileOpen.FileName).Length / 1024);
                gbPreview.Text = string.Format("Current size: {0} kB", fileSize);
               }

            pictureBox1.Image = photo.originalPhoto;
 
        }

        private string CreateTargetFilename(string originalName) {
            return Path.GetDirectoryName(originalName) + Path.PathSeparator + Path.GetFileNameWithoutExtension(originalName) + "_new" + Path.GetExtension(originalName);
            
        }

        private void btnResize_Click(object sender, EventArgs e) {
            photo.SetAllowedFileSize(Convert.ToInt32(tbFileSize.Text));
            photo.SetQuality(quality.Value);
            photo.ScalePhoto();

            SaveFileDialog fileSave = new SaveFileDialog();
            if (fileSave.ShowDialog() == DialogResult.OK) {
                photo.SaveFile(fileSave.FileName);
            }
        }

        private void tbQuality_ValueChanged(object sender, EventArgs e) {
            quality.Value = tbQuality.Value;

            if (photo != null) { photo.SetQuality(quality.Value); }
           
        }

        private void numQuality_ValueChanged(object sender, EventArgs e) {
            quality.Value = (int)numQuality.Value;

            if (photo != null) { photo.SetQuality(quality.Value); }
        }

        private void tbFileSize_Validating(object sender, CancelEventArgs e) {
            string errorMessage;
            if(!ValidFileSize(tbFileSize.Text, out errorMessage)) {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tbFileSize.Select(0, tbFileSize.Text.Length);
}
        }

        private bool ValidFileSize(string fileSize, out string errorMessage) {
            if(fileSize.Length == 0) {
                errorMessage = "Value is required";
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(fileSize, "[^0-9]")) {
                MessageBox.Show("Please enter only numbers.");
                errorMessage = "Please enter only numbers";
                return false;
            } else {
                errorMessage = string.Empty;
                return true;
            }
        }
    }
}
