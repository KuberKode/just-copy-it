
namespace JustCopyIT
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSourceFls = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.chkKeepFolderStruct = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRootFolder = new System.Windows.Forms.Button();
            this.txtRootFolder = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.openFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.foldersBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cbOverWrite = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Just Copy IT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDestinationFolder);
            this.groupBox1.Controls.Add(this.txtSourceFls);
            this.groupBox1.Controls.Add(this.txtDestinationFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File(s) Location(s)";
            // 
            // txtSourceFls
            // 
            this.txtSourceFls.Location = new System.Drawing.Point(22, 43);
            this.txtSourceFls.Multiline = true;
            this.txtSourceFls.Name = "txtSourceFls";
            this.txtSourceFls.Size = new System.Drawing.Size(387, 162);
            this.txtSourceFls.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(415, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(415, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbOverWrite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRootFolder);
            this.groupBox2.Controls.Add(this.txtRootFolder);
            this.groupBox2.Controls.Add(this.chkKeepFolderStruct);
            this.groupBox2.Location = new System.Drawing.Point(18, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copy Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination Folder";
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(415, 229);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(38, 28);
            this.btnDestinationFolder.TabIndex = 9;
            this.btnDestinationFolder.Text = "...";
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(22, 234);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(387, 20);
            this.txtDestinationFolder.TabIndex = 8;
            this.txtDestinationFolder.Text = "C:\\Temp\\Out";
            // 
            // chkKeepFolderStruct
            // 
            this.chkKeepFolderStruct.AutoSize = true;
            this.chkKeepFolderStruct.Location = new System.Drawing.Point(22, 22);
            this.chkKeepFolderStruct.Name = "chkKeepFolderStruct";
            this.chkKeepFolderStruct.Size = new System.Drawing.Size(166, 17);
            this.chkKeepFolderStruct.TabIndex = 10;
            this.chkKeepFolderStruct.Text = "Keep Source Folder Structure";
            this.chkKeepFolderStruct.UseVisualStyleBackColor = true;
            this.chkKeepFolderStruct.CheckedChanged += new System.EventHandler(this.chkKeepFolderStruct_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Root Folder";
            // 
            // btnRootFolder
            // 
            this.btnRootFolder.Enabled = false;
            this.btnRootFolder.Location = new System.Drawing.Point(415, 58);
            this.btnRootFolder.Name = "btnRootFolder";
            this.btnRootFolder.Size = new System.Drawing.Size(38, 28);
            this.btnRootFolder.TabIndex = 13;
            this.btnRootFolder.Text = "...";
            this.btnRootFolder.UseVisualStyleBackColor = true;
            this.btnRootFolder.Click += new System.EventHandler(this.btnRootFolder_Click);
            // 
            // txtRootFolder
            // 
            this.txtRootFolder.Enabled = false;
            this.txtRootFolder.Location = new System.Drawing.Point(22, 63);
            this.txtRootFolder.Name = "txtRootFolder";
            this.txtRootFolder.Size = new System.Drawing.Size(387, 20);
            this.txtRootFolder.TabIndex = 12;
            this.txtRootFolder.Text = "C:\\Temp\\In";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(397, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "Just Do it!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFilesDialog
            // 
            this.openFilesDialog.Filter = "AllFiles|*.*";
            this.openFilesDialog.InitialDirectory = "C:\\Temp\\In";
            this.openFilesDialog.Multiselect = true;
            // 
            // foldersBrowserDialog
            // 
            this.foldersBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // cbOverWrite
            // 
            this.cbOverWrite.AutoSize = true;
            this.cbOverWrite.Location = new System.Drawing.Point(233, 22);
            this.cbOverWrite.Name = "cbOverWrite";
            this.cbOverWrite.Size = new System.Drawing.Size(130, 17);
            this.cbOverWrite.TabIndex = 14;
            this.cbOverWrite.Text = "Overwrite existing files";
            this.cbOverWrite.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 505);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just Copy IT v0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSourceFls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRootFolder;
        private System.Windows.Forms.TextBox txtRootFolder;
        private System.Windows.Forms.CheckBox chkKeepFolderStruct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFilesDialog;
        private System.Windows.Forms.FolderBrowserDialog foldersBrowserDialog;
        private System.Windows.Forms.CheckBox cbOverWrite;
    }
}

