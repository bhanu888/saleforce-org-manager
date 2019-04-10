namespace SalesforceOrgManager.View
{
    partial class BoxCreazioneLightning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxCreazioneLightning));
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.groupBoxBundleType = new System.Windows.Forms.GroupBox();
            this.chkDefinitionType = new System.Windows.Forms.CheckedListBox();
            this.radioInterface = new System.Windows.Forms.RadioButton();
            this.radioEvent = new System.Windows.Forms.RadioButton();
            this.radioComponent = new System.Windows.Forms.RadioButton();
            this.radioApp = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.groupBoxBundleType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(136, 14);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(457, 30);
            this.txtItemName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateItem.Location = new System.Drawing.Point(11, 368);
            this.btnCreateItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(279, 73);
            this.btnCreateItem.TabIndex = 9;
            this.btnCreateItem.Text = "CREATE";
            this.btnCreateItem.UseVisualStyleBackColor = false;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Location = new System.Drawing.Point(296, 368);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(279, 73);
            this.btnCancelItem.TabIndex = 10;
            this.btnCancelItem.Text = "CANCEL";
            this.btnCancelItem.UseVisualStyleBackColor = true;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Gold;
            this.txtLog.Location = new System.Drawing.Point(11, 447);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(561, 86);
            this.txtLog.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(136, 69);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(457, 30);
            this.txtItemDescription.TabIndex = 12;
            // 
            // groupBoxBundleType
            // 
            this.groupBoxBundleType.Controls.Add(this.chkDefinitionType);
            this.groupBoxBundleType.Controls.Add(this.radioInterface);
            this.groupBoxBundleType.Controls.Add(this.radioEvent);
            this.groupBoxBundleType.Controls.Add(this.radioComponent);
            this.groupBoxBundleType.Controls.Add(this.radioApp);
            this.groupBoxBundleType.Location = new System.Drawing.Point(15, 110);
            this.groupBoxBundleType.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBundleType.Name = "groupBoxBundleType";
            this.groupBoxBundleType.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBundleType.Size = new System.Drawing.Size(580, 187);
            this.groupBoxBundleType.TabIndex = 14;
            this.groupBoxBundleType.TabStop = false;
            this.groupBoxBundleType.Text = "Lightning bundle type";
            // 
            // chkDefinitionType
            // 
            this.chkDefinitionType.FormattingEnabled = true;
            this.chkDefinitionType.Items.AddRange(new object[] {
            "CONTROLLER",
            "HELPER",
            "STYLE",
            "DOCUMENTATION",
            "RENDERER",
            "SVG"});
            this.chkDefinitionType.Location = new System.Drawing.Point(225, 27);
            this.chkDefinitionType.Margin = new System.Windows.Forms.Padding(4);
            this.chkDefinitionType.Name = "chkDefinitionType";
            this.chkDefinitionType.Size = new System.Drawing.Size(313, 106);
            this.chkDefinitionType.TabIndex = 4;
            // 
            // radioInterface
            // 
            this.radioInterface.AutoSize = true;
            this.radioInterface.Location = new System.Drawing.Point(8, 123);
            this.radioInterface.Margin = new System.Windows.Forms.Padding(4);
            this.radioInterface.Name = "radioInterface";
            this.radioInterface.Size = new System.Drawing.Size(84, 21);
            this.radioInterface.TabIndex = 3;
            this.radioInterface.TabStop = true;
            this.radioInterface.Text = "Interface";
            this.radioInterface.UseVisualStyleBackColor = true;
            // 
            // radioEvent
            // 
            this.radioEvent.AutoSize = true;
            this.radioEvent.Location = new System.Drawing.Point(8, 90);
            this.radioEvent.Margin = new System.Windows.Forms.Padding(4);
            this.radioEvent.Name = "radioEvent";
            this.radioEvent.Size = new System.Drawing.Size(65, 21);
            this.radioEvent.TabIndex = 2;
            this.radioEvent.TabStop = true;
            this.radioEvent.Text = "Event";
            this.radioEvent.UseVisualStyleBackColor = true;
            // 
            // radioComponent
            // 
            this.radioComponent.AutoSize = true;
            this.radioComponent.Location = new System.Drawing.Point(8, 58);
            this.radioComponent.Margin = new System.Windows.Forms.Padding(4);
            this.radioComponent.Name = "radioComponent";
            this.radioComponent.Size = new System.Drawing.Size(101, 21);
            this.radioComponent.TabIndex = 1;
            this.radioComponent.TabStop = true;
            this.radioComponent.Text = "Component";
            this.radioComponent.UseVisualStyleBackColor = true;
            // 
            // radioApp
            // 
            this.radioApp.AutoSize = true;
            this.radioApp.Location = new System.Drawing.Point(8, 27);
            this.radioApp.Margin = new System.Windows.Forms.Padding(4);
            this.radioApp.Name = "radioApp";
            this.radioApp.Size = new System.Drawing.Size(54, 21);
            this.radioApp.TabIndex = 0;
            this.radioApp.TabStop = true;
            this.radioApp.Text = "App";
            this.radioApp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Api version";
            // 
            // cmbVersions
            // 
            this.cmbVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVersions.FormattingEnabled = true;
            this.cmbVersions.Items.AddRange(new object[] {
            "38",
            "39",
            "40",
            "41",
            "42"});
            this.cmbVersions.Location = new System.Drawing.Point(11, 324);
            this.cmbVersions.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(543, 33);
            this.cmbVersions.TabIndex = 15;
            this.cmbVersions.Text = "Version...";
            // 
            // BoxCreazioneLightning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbVersions);
            this.Controls.Add(this.groupBoxBundleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnCreateItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoxCreazioneLightning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuovo elemento Lightning";
            this.groupBoxBundleType.ResumeLayout(false);
            this.groupBoxBundleType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.Button btnCancelItem;
        public System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.GroupBox groupBoxBundleType;
        public System.Windows.Forms.RadioButton radioInterface;
        public System.Windows.Forms.RadioButton radioEvent;
        public System.Windows.Forms.RadioButton radioComponent;
        public System.Windows.Forms.RadioButton radioApp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbVersions;
        public System.Windows.Forms.CheckedListBox chkDefinitionType;
    }
}