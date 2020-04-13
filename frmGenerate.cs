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
	public partial class frmGenerate:Form {
		public frmGenerate() {
			InitializeComponent();
		}
              private void frmGenerate_Activated(object sender, EventArgs e) {

                     txtProductID.Text = ComputerInfo.GetComputerId();

              }

              const int ProductCode = 1;

		private void frmGenerate_Load(object sender, EventArgs e) {

                            cboLicenseType.SelectedIndex = 0;


		}

		private void btnGenerate_Click(object sender, EventArgs e) {
                     KeyManager km = new KeyManager(txtProductID.Text);
                     KeyValuesClass kv;
                     string productKey = string.Empty;



                     if(cboLicenseType.SelectedIndex == 0) {
                                          //Generate full license key

                                          kv = new KeyValuesClass() {
                                                 Type = LicenseType.FULL,
                                                 Header = Convert.ToByte(9),
                                                 Footer = Convert.ToByte(6),
                                                 ProductCode = (byte)ProductCode,//As order of your software
                                                 Edition = Edition.ENTERPRISE,
                                                 Version = 1
                                          };

                                          if(!km.GenerateKey(kv, ref productKey)) {
                                                 txtProductKey.Text = "ERROR";
                                          }
                                  

                     } else {

                                          //Generate trial license key

                                          kv = new KeyValuesClass() {
                                                 Type = LicenseType.TRIAL,
                                                 Header = Convert.ToByte(9),
                                                 Footer = Convert.ToByte(6),
                                                 ProductCode = (byte)ProductCode,
                                                 Edition = Edition.ENTERPRISE,
                                                 Version = 1,
                                                 Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtExperience.Text))
                                          };
                                          if(!km.GenerateKey(kv, ref productKey)) {
                                                 txtProductKey.Text = "ERROR";
                                          }
                                
                     }
                     txtProductKey.Text = productKey;
              }
    }
}
