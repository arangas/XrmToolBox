﻿namespace MsCrmTools.WebResourcesManager.Forms
{
    partial class CompareSettingsDialog
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblCompareSettings = new System.Windows.Forms.Label();
            this.grpCompareSettings = new System.Windows.Forms.GroupBox();
            this.lblCommandArgs = new System.Windows.Forms.Label();
            this.txtCommandArgs = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtCommandPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.OpenInstructions = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.grpCompareSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblInstructions);
            this.panel1.Controls.Add(this.lblCompareSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(13, 41);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(337, 19);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Configure the compare tool to use for comparing files";
            // 
            // lblCompareSettings
            // 
            this.lblCompareSettings.AutoSize = true;
            this.lblCompareSettings.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompareSettings.Location = new System.Drawing.Point(10, 6);
            this.lblCompareSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompareSettings.Name = "lblCompareSettings";
            this.lblCompareSettings.Size = new System.Drawing.Size(205, 32);
            this.lblCompareSettings.TabIndex = 1;
            this.lblCompareSettings.Text = "Compare Settings";
            // 
            // grpCompareSettings
            // 
            this.grpCompareSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCompareSettings.Controls.Add(this.lblCommandArgs);
            this.grpCompareSettings.Controls.Add(this.txtCommandArgs);
            this.grpCompareSettings.Controls.Add(this.lblCommand);
            this.grpCompareSettings.Controls.Add(this.txtCommandPath);
            this.grpCompareSettings.Controls.Add(this.btnBrowse);
            this.grpCompareSettings.Location = new System.Drawing.Point(16, 81);
            this.grpCompareSettings.Margin = new System.Windows.Forms.Padding(4);
            this.grpCompareSettings.Name = "grpCompareSettings";
            this.grpCompareSettings.Padding = new System.Windows.Forms.Padding(4);
            this.grpCompareSettings.Size = new System.Drawing.Size(613, 99);
            this.grpCompareSettings.TabIndex = 1;
            this.grpCompareSettings.TabStop = false;
            this.grpCompareSettings.Text = "Compare Tool Configuration";
            // 
            // lblCommandArgs
            // 
            this.lblCommandArgs.AutoSize = true;
            this.lblCommandArgs.Location = new System.Drawing.Point(14, 61);
            this.lblCommandArgs.Name = "lblCommandArgs";
            this.lblCommandArgs.Size = new System.Drawing.Size(76, 17);
            this.lblCommandArgs.TabIndex = 4;
            this.lblCommandArgs.Text = "Arguments";
            // 
            // txtCommandArgs
            // 
            this.txtCommandArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandArgs.Location = new System.Drawing.Point(101, 59);
            this.txtCommandArgs.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommandArgs.Name = "txtCommandArgs";
            this.txtCommandArgs.Size = new System.Drawing.Size(442, 22);
            this.txtCommandArgs.TabIndex = 3;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(14, 28);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(71, 17);
            this.lblCommand.TabIndex = 2;
            this.lblCommand.Text = "Command";
            // 
            // txtCommandPath
            // 
            this.txtCommandPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandPath.Location = new System.Drawing.Point(101, 26);
            this.txtCommandPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommandPath.Name = "txtCommandPath";
            this.txtCommandPath.Size = new System.Drawing.Size(442, 22);
            this.txtCommandPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(552, 23);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(53, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(529, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(421, 192);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // OpenInstructions
            // 
            this.OpenInstructions.Interval = 1000;
            this.OpenInstructions.Tick += new System.EventHandler(this.OpenInstructions_Tick);
            // 
            // CompareSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 232);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCompareSettings);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompareSettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compare Settings";
            this.Load += new System.EventHandler(this.CompareSettingsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpCompareSettings.ResumeLayout(false);
            this.grpCompareSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpCompareSettings;
        private System.Windows.Forms.TextBox txtCommandPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCommandArgs;
        private System.Windows.Forms.TextBox txtCommandArgs;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblCompareSettings;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Timer OpenInstructions;
    }
}