namespace LicenseKey {
	partial class frmGenerate {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.cboLicenseType = new System.Windows.Forms.ComboBox();
			this.txtProductKey = new System.Windows.Forms.TextBox();
			this.txtExperience = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(122, 47);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(311, 23);
			this.txtProductID.TabIndex = 0;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(197, 188);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 1;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// cboLicenseType
			// 
			this.cboLicenseType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full",
            "TRIAL"});
			this.cboLicenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLicenseType.FormattingEnabled = true;
			this.cboLicenseType.Items.AddRange(new object[] {
            "FULL",
            "TRIAL"});
			this.cboLicenseType.Location = new System.Drawing.Point(122, 78);
			this.cboLicenseType.Name = "cboLicenseType";
			this.cboLicenseType.Size = new System.Drawing.Size(150, 24);
			this.cboLicenseType.TabIndex = 2;
			// 
			// txtProductKey
			// 
			this.txtProductKey.Location = new System.Drawing.Point(122, 145);
			this.txtProductKey.Name = "txtProductKey";
			this.txtProductKey.Size = new System.Drawing.Size(311, 23);
			this.txtProductKey.TabIndex = 3;
			// 
			// txtExperience
			// 
			this.txtExperience.Location = new System.Drawing.Point(122, 112);
			this.txtExperience.Name = "txtExperience";
			this.txtExperience.Size = new System.Drawing.Size(311, 23);
			this.txtExperience.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Product ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "License Type";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Experience Days";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Product Key";
			// 
			// frmGenerate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(484, 223);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtExperience);
			this.Controls.Add(this.txtProductKey);
			this.Controls.Add(this.cboLicenseType);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtProductID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGenerate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generate";
			this.Activated += new System.EventHandler(this.frmGenerate_Activated);
			this.Load += new System.EventHandler(this.frmGenerate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.ComboBox cboLicenseType;
		private System.Windows.Forms.TextBox txtProductKey;
		private System.Windows.Forms.TextBox txtExperience;
		public System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}