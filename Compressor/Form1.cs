using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Import the Material Skin
using MaterialSkin;
using MaterialSkin.Controls;

//Import Metrodesign
using MetroFramework.Forms;
using MetroFramework;
using System.IO;

namespace Compressor
{
    public partial class Form1 : MetroForm
    {
        List<FileStream> files = new List<FileStream>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompressor_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                MetroMessageBox.Show(this, "Compressing has been successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Something has been wrong. Please, try again");
                throw;
            }
        }

        private void btnAddingFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileName.Length > 0)
                {
                    openFileDialog1.FileName = "*.*";
                }
                openFileDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Something has been wrong. Please, try again");
                throw;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string fileName = "";
                string fileType;
                DateTime fileModified;
                double fileSize;
                string fileFullName;
                if (openFileDialog1.CheckFileExists)
                {
                    fileName = openFileDialog1.FileName;
                    if (File.Exists(fileName))
                    {
                        fileFullName = fileName;
                        fileModified = File.GetLastAccessTime(fileName);
                        FileStream fs = File.Open(fileName, FileMode.OpenOrCreate);
                        files.Add(fs);
                        fileSize = ((double)fs.Length) / 1024;
                        fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                        fileType = fileName.Substring(fileName.LastIndexOf(".") + 1);
                        fileName = fileName.Substring(0, fileName.LastIndexOf("."));
                        dataGridView1.Rows.Add(fileFullName, fileName, fileType, Math.Round(fileSize, 1) + " KB", fileModified);

                        fs.Close();
                    }

                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Something has been wrong. Please, try again");
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                FileStream nF = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                int byt;
                string fileShortName;
                int fileLengthDigitsCount;
                long fileLength;

                nF.WriteByte((byte)files.Count);

                foreach (FileStream file in files)
                {
                    FileStream fs = new FileStream(file.Name, FileMode.Open);
                    fileShortName = GetFileShortNameWithExt(file.Name);
                    nF.WriteByte((byte)fileShortName.Length);
                    for (int i = 0; i < fileShortName.Length; i++)
                    {
                        nF.WriteByte((byte)(int)(char)fileShortName[i]);
                    }

                    fileLength = fs.Length;
                    fileLengthDigitsCount = fileLength.ToString().Length;
                    nF.WriteByte((byte)fileLengthDigitsCount);
                    for (int k = 0; k < fileLengthDigitsCount; k++)
                    {
                        nF.WriteByte((byte)(fileLength % 10));
                        fileLength /= 10;
                    }

                    byt = fs.ReadByte();
                    while (byt != -1)
                    {
                        nF.WriteByte((byte)byt);
                        byt = fs.ReadByte();
                    }
                    fs.Close();
                }

                nF.Close();
                dataGridView1.Rows.Clear();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Something has been wrong. Please, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private string GetFileShortName(string fileName)
        {
            fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            fileName = fileName.Substring(0, fileName.LastIndexOf("."));
            return fileName;
        }

        private string GetFileShortNameWithExt(string fileName)
        {
            fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            return fileName;
        }

        private void btnDecompressor_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                MetroMessageBox.Show(this, "Decompressing has been successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Something has been wrong. Please, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            using (folderBrowserDialog1)
            {
                if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                try
                {
                    FileStream cF = new FileStream(openFileDialog2.FileName, FileMode.Open);
                    int byt;

                    int filesCount = cF.ReadByte();
                    int fileShortNameCount;
                    string fileShortName = "";
                    long fileLength;
                    int fileLengthDigitsCount;
                    int d;
                    string fileNewPathRoot;
                    for (int i = 0; i < filesCount; i++)
                    {
                        fileShortName = "";
                        fileShortNameCount = cF.ReadByte();
                        for (int j = 0; j < fileShortNameCount; j++)
                        {
                            fileShortName += ((char)cF.ReadByte()).ToString();
                        }
                        if (folderBrowserDialog1.SelectedPath.Length > 0)
                        {
                            fileNewPathRoot = folderBrowserDialog1.SelectedPath;
                        }
                        else
                        {
                            fileNewPathRoot = openFileDialog2.FileName.Substring(0, openFileDialog2.FileName.LastIndexOf("\\") + 1);
                        }
                        FileStream fs = new FileStream(fileNewPathRoot + fileShortName, FileMode.Create);

                        fileLength = 0;
                        fileLengthDigitsCount = cF.ReadByte();
                        for (int k = 0; k < fileLengthDigitsCount; k++)
                        {
                            d = cF.ReadByte();
                            fileLength += d * (long)(Math.Pow(10, k));
                        }

                        for (long t = 0; t < fileLength; t++)
                        {
                            byt = cF.ReadByte();
                            fs.WriteByte((byte)byt);
                        }


                        //byt = cF.ReadByte();
                        //while (byt != -1)
                        //{
                        //    fs.WriteByte((byte)byt);
                        //    byt = cF.ReadByte();
                        //}
                        fs.Close();
                    }

                    cF.Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Something has been wrong. Please, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }

}
