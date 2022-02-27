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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static gui_mail.Main;

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
                XDocument XmlKey = XDocument.Load("Key.xml");
                List<Keytlists> XmlKeyList = (from xml2 in XmlKey.Elements("ListKey").Elements("ListKey")
                                              select new Keytlists
                                              {
                                                  Key = xml2.Element("Key").Value
                                              }).ToList();
                var keyItem = XmlKeyList.FirstOrDefault().Key;
                var maHoaDES = Decrypt(keyItem, "123");
                var key = Base64Decode(maHoaDES.ToString());
                var keyPc = GetKeySystem();

                SqlConnection conn = new SqlConnection(key);
                var sqlstring = "SELECT * FROM dbo.[UserLogin] WHERE KeyLogin=N'" + keyPc + "' AND IsLock=0 ";
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
        private string GetKeySystem()
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
            var key = Base64Encode(myInfo.ToString() + "DeviceID: " + deviceId.ToString());
            return key;
        }
        private void BtnGetKey_Click(object sender, EventArgs e)
        {
            var key = GetKeySystem();
            TxtKey.Text = key.ToString();

        }
        #region Mã hóa
        //Base64 to text
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        //Text to base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        //Text to DES
        public string Encrypt(string source, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Encoding.UTF8.GetBytes(source);

            string encoded =
                Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return encoded;
        }
        //DES to text
        public static string Decrypt(string encodedText, string key)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.ECB; //CBC, CFB
            byteBuff = Convert.FromBase64String(encodedText);

            string plaintext = Encoding.UTF8.GetString(desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            return plaintext;
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {


        }
    }
}
