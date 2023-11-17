using DeviceId;
using System;
using System.Data.SqlClient;
using System.Management;
using System.Windows.Forms;

namespace gui_mail
{
    public partial class Login : Form
    {
        private SqlConnection conn = new SqlConnection("server=125.212.224.205;database=nanodevp_netcore;uid=nanodevp_net;password=jx31xV*28;MultipleActiveResultSets=True;App=EntityFramework");

        public Login()
        {
            InitializeComponent();
        }

        private void TxtGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string keylogin = GetkeyInfo();
                bool flag = CheckKey(keylogin);
                if (!flag)
                {
                    try
                    {
                        InsetInfoUser();
                    }
                    catch (Exception)
                    {
                    }
                }
                if (flag)
                {
                    Main main = new Main();
                    main.ShowDialog();
                    Close();
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
            string text = GetkeyInfo();
            TxtKey.Text = text.ToString();
        }

        private bool CheckKey(string keylogin)
        {
            string cmdText = "SELECT * FROM dbo.[UserMail] WHERE [KeyLogin]=N'" + keylogin.ToString() + "' AND ISNULL(IsLock,0)=0  ";
            SqlCommand sqlCommand = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool result = sqlDataReader.Read();
            conn.Close();
            return result;
        }

        private bool CheckKeyAll(string keylogin)
        {
            string cmdText = "SELECT * FROM dbo.[UserMail] WHERE [KeyLogin]=N'" + keylogin.ToString() + "'  ";
            SqlCommand sqlCommand = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool result = sqlDataReader.Read();
            conn.Close();
            return result;
        }

        private void InsetInfoUser()
        {
            string text = GetkeyInfo();
            if (!CheckKeyAll(text))
            {
                string cmdText = "INSERT INTO dbo.UserMail (KeyLogin,Name,IsLock,Note) VALUES(N'" + text.ToString() + "',N'',1,N'')";
                SqlCommand sqlCommand = new SqlCommand(cmdText, conn);
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                conn.Close();
            }
        }

  

        private string GetkeyInfo()
        {
            BasicInfo basicInfo = new BasicInfo
            {
                OsVersion = Environment.OSVersion.ToString(),
                PcName = Environment.MachineName
            };
            string text = new DeviceIdBuilder().AddMachineName().AddMacAddress().AddProcessorId()
                .AddMotherboardSerialNumber()
                .ToString();
            return Base64Encode(basicInfo.ToString() + "DeviceID: " + text.ToString());
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

        #endregion Mã hóa
    }
}