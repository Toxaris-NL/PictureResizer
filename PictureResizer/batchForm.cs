using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PictureResizer
{
    public partial class batchForm : Form
    {
        internal DataTable batch;

        public batchForm()
        {
            InitializeComponent();
            InitBatchGrid();
            tbFileSize.Text = "1000";
            tbQuality.Text = "90";
        }

        private void InitBatchGrid()
        {
            initBatchtable();
            BindingSource binding = new BindingSource
            {
                DataSource = batch
            };
            dgvBatch.AutoGenerateColumns = true;
            dgvBatch.DataSource = batch;
            dgvBatch.DataSource = binding;
            dgvBatch.Refresh();

            for (int i = 0; i < dgvBatch.Columns.Count; i++)
            {
                dgvBatch.Columns[i].DataPropertyName = batch.Columns[i].ColumnName;
                dgvBatch.Columns[i].HeaderText = batch.Columns[i].Caption;
                dgvBatch.Columns[i].ReadOnly = true;
            }
            dgvBatch.Columns["quality"].ReadOnly = false;
            dgvBatch.Columns["targetsize"].ReadOnly = false;
            dgvBatch.AutoResizeColumns();
        }

        internal void initBatchtable()
        {
            Dictionary<string, string> columns = new Dictionary<string, string>
            {
                {"source", "Source image" },
                {"target", "Target image" },
                {"quality", "Quality"},
                {"currentsize" ,"Current size (kB)"},
                {"targetsize", "Target size (kB)" },
                {"status", "Status" }
            };
            batch = new DataTable();
            batch.Clear();
            foreach (string key in columns.Keys)
            {
                DataColumn column = new DataColumn(key)
                {
                    Caption = columns[key],
                    ColumnName = key
                };
                batch.Columns.Add(column);
            }
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg; *.jpeg",
                Title = "Select file",
                CheckFileExists = true,
                Multiselect = true
            };
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in fileOpen.FileNames)
                {
                    AddFile(file);
                }
            }
            dgvBatch.AutoResizeColumns();
        }

        private void btnDir_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog selectDir = new FolderBrowserDialog
            {
                Description = "Select folder to process",
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            if (selectDir.ShowDialog() == DialogResult.OK && Directory.Exists(selectDir.SelectedPath))
            {
                AddFolder(selectDir.SelectedPath);
            }
            dgvBatch.AutoResizeColumns();
        }

        private void AddFolder(string folder)
        {
            var fileEntries = Directory.GetFiles(folder).Where(x => Regex.IsMatch(Path.GetExtension(x).ToLower(), @"\.(jpg|jpeg)"));
            foreach (string file in fileEntries)
            {
                AddFile(file);
            }
        }

        private void AddFile(string file)
        {
            DataRow newRow = batch.NewRow();
            newRow["source"] = file;
            newRow["target"] = support.CreateTargetFilename(file);
            newRow["quality"] = tbQuality.Text;
            newRow["currentsize"] = (new FileInfo(file).Length / 1024);
            newRow["targetsize"] = tbFileSize.Text;
            newRow["status"] = "new";
            batch.Rows.Add(newRow);
        }

        private void IntegerValidating(object sender, CancelEventArgs e)
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in batch.Rows)
            {
                int targetSize = Convert.ToInt32(row["targetsize"].ToString());
                int sourceSize = Convert.ToInt32(row["currentsize"].ToString());
                if (targetSize >= sourceSize)
                {
                    row["status"] = "Ignored";
                    dgvBatch.Refresh();
                    continue;
                }

                try
                {
                    Photo photo = new Photo(Image.FromFile(row["source"].ToString()));
                    photo.SetSourceInfo(row["source"].ToString());
                    photo.SetAllowedFileSize(Convert.ToInt32(row["targetsize"].ToString()));
                    photo.SetQuality(Convert.ToInt32(row["quality"].ToString()));
                    photo.ScalePhoto();
                    photo.SaveFile(row["target"].ToString());
                    row["status"] = "OK";
                    dgvBatch.Refresh();
                }
                catch (Exception ex)
                {
                    row["status"] = "Error";
                    support.logger.Error("Error converting image. Error message: {0}", ex.Message);
                    dgvBatch.Refresh();
                }
            }
        }

        private void dgvBatch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != -1 && dgvBatch.Columns[e.ColumnIndex].Name.Equals("status"))
            {
                if (e.Value.ToString().Equals("Error"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (e.Value.ToString().Equals("OK"))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                if (e.Value.ToString().Equals("Ignored"))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dgvBatch_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvBatch.Columns[e.ColumnIndex].Name.Equals("targetsize") || dgvBatch.Columns[e.ColumnIndex].Name.Equals("quality"))
            {
                string errorMessage;
                if (!support.ValidInteger(e.FormattedValue.ToString(), out errorMessage))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    dgvBatch.Rows[e.RowIndex].ErrorText = errorMessage;
                    e.Cancel = true;
                }
            }
        }
    }
}