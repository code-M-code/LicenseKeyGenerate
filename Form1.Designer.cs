namespace LicenseKey {
	partial class Form1 {
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent() {
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnRegistration = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(23, 43);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(90, 30);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnRegistration
			// 
			this.btnRegistration.Location = new System.Drawing.Point(151, 43);
			this.btnRegistration.Name = "btnRegistration";
			this.btnRegistration.Size = new System.Drawing.Size(90, 30);
			this.btnRegistration.TabIndex = 1;
			this.btnRegistration.Text = "Registration";
			this.btnRegistration.UseVisualStyleBackColor = true;
			this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(283, 43);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(90, 30);
			this.btnAbout.TabIndex = 2;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(399, 109);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnRegistration);
			this.Controls.Add(this.btnGenerate);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generate Serial ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnRegistration;
		private System.Windows.Forms.Button btnAbout;
	}
}

