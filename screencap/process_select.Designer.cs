﻿namespace screencap
{
    partial class process_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(process_select));
            this.ListBox_process = new System.Windows.Forms.ListBox();
            this.pictureBox_process = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_process)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox_process
            // 
            this.ListBox_process.DisplayMember = "ListBoxData";
            this.ListBox_process.FormattingEnabled = true;
            this.ListBox_process.ItemHeight = 12;
            this.ListBox_process.Location = new System.Drawing.Point(12, 12);
            this.ListBox_process.Name = "ListBox_process";
            this.ListBox_process.Size = new System.Drawing.Size(222, 88);
            this.ListBox_process.TabIndex = 0;
            this.ListBox_process.SelectedIndexChanged += new System.EventHandler(this.ListBox_process_SelectedIndexChanged);
            this.ListBox_process.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_process_MouseDoubleClick);
            // 
            // pictureBox_process
            // 
            this.pictureBox_process.Location = new System.Drawing.Point(12, 106);
            this.pictureBox_process.Name = "pictureBox_process";
            this.pictureBox_process.Size = new System.Drawing.Size(222, 200);
            this.pictureBox_process.TabIndex = 2;
            this.pictureBox_process.TabStop = false;
            // 
            // process_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 316);
            this.Controls.Add(this.pictureBox_process);
            this.Controls.Add(this.ListBox_process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "process_select";
            this.Text = "Select Your Toon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_process;
        private System.Windows.Forms.PictureBox pictureBox_process;
    }
}