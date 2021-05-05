/*
MIT License

Copyright (c) 2021 Johan Strydom

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JustCopyIT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSourceFls.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dRes = openFilesDialog.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                foreach(string fl in openFilesDialog.FileNames) {
                    if (txtSourceFls.TextLength > 0) {
                        txtSourceFls.Text += Environment.NewLine;
                    }
                    txtSourceFls.Text += fl;
                }
                
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            DialogResult dRes = foldersBrowserDialog.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                txtDestinationFolder.Text = foldersBrowserDialog.SelectedPath;
            }
        }

        private void chkKeepFolderStruct_CheckedChanged(object sender, EventArgs e)
        {

            if (chkKeepFolderStruct.Checked)
            {
                txtRootFolder.Enabled = true;
                btnRootFolder.Enabled = true;
            }
            if (!chkKeepFolderStruct.Checked)
            {
                txtRootFolder.Enabled = false;
                btnRootFolder.Enabled = false;
            }
        }

        private void btnRootFolder_Click(object sender, EventArgs e)
        {
            DialogResult dRes = foldersBrowserDialog.ShowDialog(this);
            if (dRes == DialogResult.OK)
            {
                txtRootFolder.Text = foldersBrowserDialog.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (txtSourceFls.Text.Length == 0)
            {
                MessageBox.Show(this, "Please select source file(s)");
                this.Cursor = Cursors.Default;
                return;
            }

            if (txtDestinationFolder.Text.Length == 0)
            {
                MessageBox.Show(this, "Please select a destination folder");
                this.Cursor = Cursors.Default;
                return;
            }

            char DS = Path.DirectorySeparatorChar;
            string targetLocation = txtDestinationFolder.Text;

            foreach (string sourceFileLine in txtSourceFls.Lines)
            {
                try {

                    string[] sourcePath = sourceFileLine.Split('\\');
                    string sourceFile = sourcePath.Last();

                    
                    //keep folder structure according to root
                    if (chkKeepFolderStruct.Checked) {
                        if (!sourceFileLine.Contains(txtRootFolder.Text)) {
                            MessageBox.Show(this, "Error: Root (" + txtRootFolder.Text + ") not found for file " + sourceFileLine);
                            continue;
                        }
                        string rootFolder = txtRootFolder.Text;
                        if (rootFolder.Last() == DS) {
                            rootFolder = rootFolder.Substring(0, rootFolder.Length - 1);
                        }
                        sourceFile = sourceFileLine.Replace(rootFolder + DS,"");
                        sourcePath = sourceFile.Split('\\');
                        //See if directories exist then create it if not found
                        string subStruct = targetLocation;
                        for (int i = 0; i< (sourcePath.Length-1); i++) {
                            subStruct += DS + sourcePath[i];
                            if (!System.IO.Directory.Exists(subStruct)) {
                                System.IO.Directory.CreateDirectory(subStruct);
                            }
                        }
                    }
                    string destFileLine = targetLocation + DS + sourceFile;

                    bool overwrite = false;
                    if (cbOverWrite.Checked) {
                        overwrite = true;
                    }

                    System.IO.File.Copy(sourceFileLine, destFileLine, overwrite);

                }
                catch (System.Exception error)
                {
                    MessageBox.Show(this, "Error: " + error.Message);
                }
            }
            
            this.Cursor = Cursors.Default;
            MessageBox.Show(this, "~ Copy Finished ~");
            btnClear_Click(sender, e);
        }
    }
}
