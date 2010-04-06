﻿namespace XML_Playlist_Generator
{
    partial class fMain
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
            this.lbSelectFolder = new System.Windows.Forms.Label();
            this.txtRootfolder = new System.Windows.Forms.TextBox();
            this.btBrowseRoot = new System.Windows.Forms.Button();
            this.txtPlaylist = new System.Windows.Forms.TextBox();
            this.lbSelectPlaylist = new System.Windows.Forms.Label();
            this.btBrowseFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btCreatePlaylist = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSelectFolder
            // 
            this.lbSelectFolder.AutoSize = true;
            this.lbSelectFolder.Location = new System.Drawing.Point(12, 9);
            this.lbSelectFolder.Name = "lbSelectFolder";
            this.lbSelectFolder.Size = new System.Drawing.Size(159, 18);
            this.lbSelectFolder.TabIndex = 0;
            this.lbSelectFolder.Text = "Select your root folder";
            // 
            // txtRootfolder
            // 
            this.txtRootfolder.Location = new System.Drawing.Point(12, 27);
            this.txtRootfolder.Name = "txtRootfolder";
            this.txtRootfolder.Size = new System.Drawing.Size(559, 26);
            this.txtRootfolder.TabIndex = 1;
            this.txtRootfolder.Text = "D:\\Musik\\Metallica";
            // 
            // btBrowseRoot
            // 
            this.btBrowseRoot.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btBrowseRoot.Location = new System.Drawing.Point(577, 24);
            this.btBrowseRoot.Name = "btBrowseRoot";
            this.btBrowseRoot.Size = new System.Drawing.Size(124, 31);
            this.btBrowseRoot.TabIndex = 2;
            this.btBrowseRoot.Text = "Browse";
            this.btBrowseRoot.UseVisualStyleBackColor = true;
            this.btBrowseRoot.Click += new System.EventHandler(this.btBrowseRoot_Click);
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.Location = new System.Drawing.Point(12, 77);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Size = new System.Drawing.Size(559, 26);
            this.txtPlaylist.TabIndex = 3;
            this.txtPlaylist.Text = "C:\\Users\\Jan Schulte\\Documents\\Test.xml";
            // 
            // lbSelectPlaylist
            // 
            this.lbSelectPlaylist.AutoSize = true;
            this.lbSelectPlaylist.Location = new System.Drawing.Point(12, 56);
            this.lbSelectPlaylist.Name = "lbSelectPlaylist";
            this.lbSelectPlaylist.Size = new System.Drawing.Size(205, 18);
            this.lbSelectPlaylist.TabIndex = 4;
            this.lbSelectPlaylist.Text = "Select a path for your playlist";
            // 
            // btBrowseFile
            // 
            this.btBrowseFile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btBrowseFile.Location = new System.Drawing.Point(577, 74);
            this.btBrowseFile.Name = "btBrowseFile";
            this.btBrowseFile.Size = new System.Drawing.Size(124, 31);
            this.btBrowseFile.TabIndex = 5;
            this.btBrowseFile.Text = "Browse";
            this.btBrowseFile.UseVisualStyleBackColor = true;
            this.btBrowseFile.Click += new System.EventHandler(this.btBrowseFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 31);
            this.progressBar1.TabIndex = 6;
            // 
            // btCreatePlaylist
            // 
            this.btCreatePlaylist.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btCreatePlaylist.Location = new System.Drawing.Point(577, 109);
            this.btCreatePlaylist.Name = "btCreatePlaylist";
            this.btCreatePlaylist.Size = new System.Drawing.Size(124, 31);
            this.btCreatePlaylist.TabIndex = 7;
            this.btCreatePlaylist.Text = "Create playlist";
            this.btCreatePlaylist.UseVisualStyleBackColor = true;
            this.btCreatePlaylist.Click += new System.EventHandler(this.btCreatePlaylist_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 39);
            this.textBox1.TabIndex = 8;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(722, 213);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btCreatePlaylist);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btBrowseFile);
            this.Controls.Add(this.lbSelectPlaylist);
            this.Controls.Add(this.txtPlaylist);
            this.Controls.Add(this.btBrowseRoot);
            this.Controls.Add(this.txtRootfolder);
            this.Controls.Add(this.lbSelectFolder);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.Opacity = 0.8D;
            this.Text = "XML Playlist Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSelectFolder;
        private System.Windows.Forms.TextBox txtRootfolder;
        private System.Windows.Forms.Button btBrowseRoot;
        private System.Windows.Forms.TextBox txtPlaylist;
        private System.Windows.Forms.Label lbSelectPlaylist;
        private System.Windows.Forms.Button btBrowseFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btCreatePlaylist;
        private System.Windows.Forms.TextBox textBox1;
    }
}

