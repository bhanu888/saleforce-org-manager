namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneTrigger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneTrigger));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbObjects = new System.Windows.Forms.ComboBox();
            this.chkEvents = new System.Windows.Forms.CheckedListBox();
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
            this.btnCreateItem.Location = new System.Drawing.Point(13, 443);
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
            this.btnCancelItem.Location = new System.Drawing.Point(299, 443);
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
            this.txtLog.Location = new System.Drawing.Point(13, 522);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(561, 86);
            this.txtLog.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbObjects);
            this.groupBox1.Controls.Add(this.chkEvents);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(561, 332);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "triggered events";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Referring object";
            // 
            // cmbObjects
            // 
            this.cmbObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbObjects.FormattingEnabled = true;
            this.cmbObjects.Location = new System.Drawing.Point(16, 287);
            this.cmbObjects.Margin = new System.Windows.Forms.Padding(4);
            this.cmbObjects.Name = "cmbObjects";
            this.cmbObjects.Size = new System.Drawing.Size(528, 33);
            this.cmbObjects.TabIndex = 1;
            this.cmbObjects.Text = "Referring object...";
            // 
            // chkEvents
            // 
            this.chkEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEvents.FormattingEnabled = true;
            this.chkEvents.Items.AddRange(new object[] {
            "before insert",
            "after insert",
            "before update",
            "after update",
            "before delete",
            "after delete",
            "before undelete",
            "after undelete"});
            this.chkEvents.Location = new System.Drawing.Point(16, 25);
            this.chkEvents.Margin = new System.Windows.Forms.Padding(4);
            this.chkEvents.Name = "chkEvents";
            this.chkEvents.Size = new System.Drawing.Size(528, 204);
            this.chkEvents.TabIndex = 0;
            // 
            // BoxCreazioneTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BoxCreazioneTrigger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuovo trigger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckedListBox chkEvents;
        public System.Windows.Forms.ComboBox cmbObjects;
        public System.Windows.Forms.TextBox txtItemName;
    }
}