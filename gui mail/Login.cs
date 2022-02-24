using DeviceId;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_mail
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TxtGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"data source=DESKTOP-2LILVUD\SQLEXPRESS;initial catalog=Mail;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
                var sqlstring = "SELECT * FROM dbo.[User] WHERE [Key]=N'"+TxtKey.Text+ "' AND IsLock=0 ";
                SqlCommand cmd = new SqlCommand(sqlstring, conn);
                conn.Open();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    this.Hide();
                    Main f = new Main();
                    f.Show();
                    
                }
                else
                {
                    MessageBox.Show("Your acount is not existing in system or locked, please contact your admin");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Can not connect to server");
            }
           
        }
        private void BtnGetKey_Click(object sender, EventArgs e)
        {
            BasicInfo myInfo = new BasicInfo
            {
                OsVersion = Environment.OSVersion.ToString(),
                PcName = Environment.MachineName,
                UserName = Environment.UserName
            };

            string deviceId = new DeviceIdBuilder()
            .AddMachineName()
            .AddMacAddress()
            .AddProcessorId()
            .AddMotherboardSerialNumber()
            .ToString();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            var key = Base64Encode(myInfo.ToString() +"DeviceID: " +deviceId.ToString());
            TxtKey.Text = key.ToString();
        }
        #region Mã hóa
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        #endregion
    }
}
