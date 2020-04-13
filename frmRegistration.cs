using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;

namespace LicenseKey {
	public partial class frmRegistration:Form {
		public frmRegistration() {
			InitializeComponent();
		}
              const int ProductCode = 1;
              private void frmRegistration_Load(object sender, EventArgs e) {
                     txtUserName.Text = Environment.UserName;
              }

		private void btnOK_Click(object sender, EventArgs e) {
                     KeyManager km = new KeyManager(txtProductID.Text);
                     string productKey = txtProductKey.Text;
                     //Check valid
                     if(km.ValidKey(ref productKey)) {

                            KeyValuesClass kv = new KeyValuesClass();
                            //Decrypt license key
                            if(km.DisassembleKey(productKey, ref kv)) {

                                   LicenseInfo lic = new LicenseInfo();

                                   lic.ProductKey = productKey;

                                   lic.FullName = txtUserName.Text;

                                   if(kv.Type == LicenseType.TRIAL) {
                                          lic.Day = kv.Expiration.Day;
                                          lic.Month = kv.Expiration.Month;
                                          lic.Year = kv.Expiration.Year;
                                   }

                                   //Save license key to file
                                   km.SaveSuretyFile(string.Format(@"{0}\LicenseInfo.lic", Application.StartupPath), lic);

                                   MessageBox.Show("You have been successfully registered.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                   this.Close();
                            }

                     } else {
                     
                            MessageBox.Show("Your product key is invalid.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
              }

              private void frmRegistration_Activated(object sender, EventArgs e) {
                     txtProductID.Text = ComputerInfo.GetComputerId();
              }
       }
}
