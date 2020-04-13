namespace LicenseKey {
	partial class frmAbout {
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
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductID = new System.Windows.Forms.Label();
			this.lblProductKey = new System.Windows.Forms.Label();
			this.lblLicenseType = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 12;
			this.label4.Text = "Product Key";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "License Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Product ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Product Name";
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(111, 45);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(17, 16);
			this.lblProductName.TabIndex = 13;
			this.lblProductName.Text = "...";
			// 
			// lblProductID
			// 
			this.lblProductID.AutoSize = true;
			this.lblProductID.Location = new System.Drawing.Point(112, 77);
			this.lblProductID.Name = "lblProductID";
			this.lblProductID.Size = new System.Drawing.Size(17, 16);
			this.lblProductID.TabIndex = 14;
			this.lblProductID.Text = "...";
			// 
			// lblProductKey
			// 
			this.lblProductKey.AutoSize = true;
			this.lblProductKey.Location = new System.Drawing.Point(112, 108);
			this.lblProductKey.Name = "lblProductKey";
			this.lblProductKey.Size = new System.Drawing.Size(17, 16);
			this.lblProductKey.TabIndex = 15;
			this.lblProductKey.Text = "...";
			// 
			// lblLicenseType
			// 
			this.lblLicenseType.AutoSize = true;
			this.lblLicenseType.Location = new System.Drawing.Point(114, 142);
			this.lblLicenseType.Name = "lblLicenseType";
			this.lblLicenseType.Size = new System.Drawing.Size(17, 16);
			this.lblLicenseType.TabIndex = 16;
			this.lblLicenseType.Text = "...";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(179, 188);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 223);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblLicenseType);
			this.Controls.Add(this.lblProductKey);
			this.Controls.Add(this.lblProductID);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.Load += new System.EventHandler(this.frmAbout_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.Label lblProductID;
		private System.Windows.Forms.Label lblProductKey;
		private System.Windows.Forms.Label lblLicenseType;
		private System.Windows.Forms.Button button1;
	}
}