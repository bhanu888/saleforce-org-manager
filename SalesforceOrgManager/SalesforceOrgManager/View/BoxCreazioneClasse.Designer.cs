﻿namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneClasse));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(118, 12);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(457, 30);
            this.txtItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateItem.Location = new System.Drawing.Point(13, 61);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(279, 73);
            this.btnCreateItem.TabIndex = 4;
            this.btnCreateItem.Text = "CREATE";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(298, 61);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(279, 73);
            this.btnCancelItem.TabIndex = 5;
            this.btnCancelItem.Text = "CANCEL";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gold;
            this.txtLog.Location = new System.Drawing.Point(13, 140);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(561, 87);
            this.txtLog.TabIndex = 6;
            // 
            // BoxCreazioneClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 240);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BoxCreazioneClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuova classe Apex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
    }
}