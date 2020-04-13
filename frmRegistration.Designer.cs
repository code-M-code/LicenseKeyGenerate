namespace LicenseKey {
	partial class frmRegistration {
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
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductKey = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(176, 171);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(95, 29);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Registration";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Product ID";
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(142, 62);
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.ReadOnly = true;
			this.txtProductID.Size = new System.Drawing.Size(311, 23);
			this.txtProductID.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "Product Key";
			// 
			// txtProductKey
			// 
			this.txtProductKey.Location = new System.Drawing.Point(142, 105);
			this.txtProductKey.Name = "txtProductKey";
			this.txtProductKey.Size = new System.Drawing.Size(311, 23);
			this.txtProductKey.TabIndex = 9;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(142, 19);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.ReadOnly = true;
			this.txtUserName.Size = new System.Drawing.Size(311, 23);
			this.txtUserName.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "UserName";
			// 
			// frmRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 223);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductKey);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProductID);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registration";
			this.Activated += new System.EventHandler(this.frmRegistration_Activated);
			this.Load += new System.EventHandler(this.frmRegistration_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtProductID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductKey;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label5;
	}
}