using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseKey {
	public partial class frmAbout:Form {
		public frmAbout() {
			InitializeComponent();
		}

		private void frmAbout_Load(object sender, EventArgs e) {
                     lblProductID.Text = ComputerInfo.GetComputerId();
                     KeyManager km = new KeyManager(lblProductID.Text);
                     LicenseInfo lic = new LicenseInfo();
                     //Get license information from license file
                     int value = km.LoadSuretyFile(string.Format(@"{0}\LicenseInfo.lic", Application.StartupPath), ref lic);
                     string productKey = lic.ProductKey;
                     //Check valid
                     if(km.ValidKey(ref productKey)) {
                            KeyValuesClass kv = new KeyValuesClass();
                            //Decrypt license key
                            if(km.DisassembleKey(productKey, ref kv)) {

                                   lblProductName.Text = lic.FullName;

                                   lblProductKey.Text = productKey;

                                   if(kv.Type == LicenseType.TRIAL) {

                                          lblLicenseType.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);

                                   } else {
                                   
                                          lblLicenseType.Text = "Full";
                                   }
                            }
                     }
              }

              private void button1_Click(object sender, EventArgs e) {
                     this.Close();
              }
       }
}
