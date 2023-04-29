namespace Compressor
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddingFile = new MetroFramework.Controls.MetroButton();
            this.btnCompressor = new MetroFramework.Controls.MetroButton();
            this.btnDecompressor = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridFileFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFileModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.*";
            this.openFileDialog1.Title = "Choosing file";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 98);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnAddingFile
            // 
            this.btnAddingFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddingFile.BackgroundImage = global::Compressor.Properties.Resources.file_add_512_3;
            this.btnAddingFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddingFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddingFile.Location = new System.Drawing.Point(3, 3);
            this.btnAddingFile.Name = "btnAddingFile";
            this.btnAddingFile.Size = new System.Drawing.Size(78, 68);
            this.btnAddingFile.TabIndex = 3;
            this.btnAddingFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddingFile.UseSelectable = true;
            this.btnAddingFile.Click += new System.EventHandler(this.btnAddingFile_Click);
            // 
            // btnCompressor
            // 
            this.btnCompressor.BackColor = System.Drawing.Color.Transparent;
            this.btnCompressor.BackgroundImage = global::Compressor.Properties.Resources.archives_2;
            this.btnCompressor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompressor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompressor.Location = new System.Drawing.Point(86, 3);
            this.btnCompressor.Name = "btnCompressor";
            this.btnCompressor.Size = new System.Drawing.Size(77, 68);
            this.btnCompressor.TabIndex = 4;
            this.btnCompressor.UseSelectable = true;
            this.btnCompressor.Click += new System.EventHandler(this.btnCompressor_Click);
            // 
            // btnDecompressor
            // 
            this.btnDecompressor.BackColor = System.Drawing.Color.Transparent;
            this.btnDecompressor.BackgroundImage = global::Compressor.Properties.Resources.unarchiver_2;
            this.btnDecompressor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecompressor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecompressor.Location = new System.Drawing.Point(169, 3);
            this.btnDecompressor.Name = "btnDecompressor";
            this.btnDecompressor.Size = new System.Drawing.Size(78, 68);
            this.btnDecompressor.TabIndex = 5;
            this.btnDecompressor.UseSelectable = true;
            this.btnDecompressor.Click += new System.EventHandler(this.btnDecompressor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridFileFullName,
            this.GridFileName,
            this.GridFileType,
            this.GridFileSize,
            this.GridFileModified});
            this.dataGridView1.Location = new System.Drawing.Point(15, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 229);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GridFileFullName
            // 
            this.GridFileFullName.HeaderText = "File Full Name";
            this.GridFileFullName.Name = "GridFileFullName";
            this.GridFileFullName.ReadOnly = true;
            this.GridFileFullName.Visible = false;
            // 
            // GridFileName
            // 
            this.GridFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GridFileName.HeaderText = "Name";
            this.GridFileName.Name = "GridFileName";
            this.GridFileName.ReadOnly = true;
            // 
            // GridFileType
            // 
            this.GridFileType.HeaderText = "File type";
            this.GridFileType.Name = "GridFileType";
            this.GridFileType.ReadOnly = true;
            this.GridFileType.Width = 150;
            // 
            // GridFileSize
            // 
            this.GridFileSize.HeaderText = "Size";
            this.GridFileSize.Name = "GridFileSize";
            this.GridFileSize.ReadOnly = true;
            this.GridFileSize.Width = 150;
            // 
            // GridFileModified
            // 
            this.GridFileModified.HeaderText = "Modified date";
            this.GridFileModified.Name = "GridFileModified";
            this.GridFileModified.ReadOnly = true;
            this.GridFileModified.Width = 150;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "just";
            this.saveFileDialog1.FileName = "*.just";
            this.saveFileDialog1.Title = "Saving files as a compressed file";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "*.*";
            this.openFileDialog2.Title = "Choose a compressed file";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose directory for saving file(s)";
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(4, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 17);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Adding file";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(90, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 14);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Compressing";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33168F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCompressor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddingFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDecompressor, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.19889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.80111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 92);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(169, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 15);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Uncompressing";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Compressor";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnAddingFile;
        private MetroFramework.Controls.MetroButton btnCompressor;
        private MetroFramework.Controls.MetroButton btnDecompressor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridFileModified;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

