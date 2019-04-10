namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneRisorsaStatica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneRisorsaStatica));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkZippedBundle = new System.Windows.Forms.RadioButton();
            this.chkSingleFile = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(117, 12);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnCreateItem.Location = new System.Drawing.Point(13, 176);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(279, 73);
            this.btnCreateItem.TabIndex = 4;
            this.btnCreateItem.Text = "CREATE";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(299, 176);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtLog.Location = new System.Drawing.Point(13, 255);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(561, 86);
            this.txtLog.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkZippedBundle);
            this.groupBox1.Controls.Add(this.chkSingleFile);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(561, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resource format";
            // 
            // chkZippedBundle
            // 
            this.chkZippedBundle.AutoSize = true;
            this.chkZippedBundle.Location = new System.Drawing.Point(285, 38);
            this.chkZippedBundle.Margin = new System.Windows.Forms.Padding(4);
            this.chkZippedBundle.Name = "chkZippedBundle";
            this.chkZippedBundle.Size = new System.Drawing.Size(178, 21);
            this.chkZippedBundle.TabIndex = 1;
            this.chkZippedBundle.Text = "zipped resource bundle";
            this.chkZippedBundle.UseVisualStyleBackColor = true;
            // 
            // chkSingleFile
            // 
            this.chkSingleFile.AutoSize = true;
            this.chkSingleFile.Checked = true;
            this.chkSingleFile.Location = new System.Drawing.Point(25, 38);
            this.chkSingleFile.Margin = new System.Windows.Forms.Padding(4);
            this.chkSingleFile.Name = "chkSingleFile";
            this.chkSingleFile.Size = new System.Drawing.Size(88, 21);
            this.chkSingleFile.TabIndex = 0;
            this.chkSingleFile.TabStop = true;
            this.chkSingleFile.Text = "single file";
            this.chkSingleFile.UseVisualStyleBackColor = true;
            // 
            // BoxCreazioneRisorsaStatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BoxCreazioneRisorsaStatica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuova risorsa statica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton chkZippedBundle;
        public System.Windows.Forms.RadioButton chkSingleFile;
    }
}