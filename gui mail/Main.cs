using Aspose.Email;
using Aspose.Email.Clients;
using Aspose.Email.Clients.Smtp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace gui_mail
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string[] str2 = new string[30];
        private List<Emp> Listmail = new List<Emp>();
        private List<string> ListError = new List<string>();
        private ManualResetEvent re = new ManualResetEvent(true);
        public Boolean run = true;

        #region Class

        public class Emp
        {
            public string UsernameMail { get; set; }
            public string PasswordMail { get; set; }

            public Emp(string UsernameMail, string PasswordMail)
            {
                this.UsernameMail = UsernameMail;
                this.PasswordMail = PasswordMail;
            }
        }

        public class Emaillists
        {
            public String UserName { get; set; }
            public String Password { get; set; }
        }

        public class Contentlists
        {
            public String TieuDe { get; set; }
            public String NoiDung { get; set; }
        }

        #endregion Class

        private void ContentMail(string mailReceive)
        {
            // Tạo một thể hiện mới của lớp MailMessage
            MailMessage message = new MailMessage();

            // Đặt chủ đề của tin nhắn, nội dung Html và thông tin người gửi
            message.Subject = TxtChuDe.Text;
            message.HtmlBody = TxtNoiDung.Text;
            message.From = new MailAddress("admin@azm.pics", "Sender Name", false);
            message.To.Add(new MailAddress(mailReceive, "Recipient 1", false));

            // Lưu tin nhắn ở định dạng EML/EMLX/MSG/MHTML
            message.Save("EmailMessage.eml", Aspose.Email.SaveOptions.DefaultEml);
        }

        private void MailConfig(string receiveMail,string userName,string passWord)
        {
            ContentMail(receiveMail);
            // Tạo phiên bản MailMessage. Bạn có thể tạo một tin nhắn mới hoặc tải một tệp tin nhắn đã tạo (eml, msg, v.v.)
            MailMessage msg = MailMessage.Load("EmailMessage.eml");

            // Tạo một thể hiện của lớp SmtpClient
            SmtpClient client = new SmtpClient();

            // Chỉ định Máy chủ gửi thư, Tên người dùng, Mật khẩu, Cổng # và tùy chọn Bảo mật của bạn
            client.Host = label1.Text;
            client.Username = userName;
            client.Password = passWord;
            client.Port = int.Parse(TxtPort.Text);
            client.SecurityOptions = SecurityOptions.SSLExplicit;
            // Gửi email này
            //client.Send(msg);
        }

        public void SendMail()
        {
            XDocument XmlEmail = XDocument.Load("EmailList.xml");
            List<Emaillists> EmailList = (from xml in XmlEmail.Elements("ListMail").Elements("Email")
                                          select new Emaillists
                                          {
                                              UserName = xml.Element("UserName").Value,
                                              Password = xml.Element("Password").Value
                                          }).ToList();

            XDocument XmlContent = XDocument.Load("ContentList.xml");
            List<Contentlists> ContentlList = (from xml2 in XmlContent.Elements("ListContent").Elements("ListContent")
                                               select new Contentlists
                                               {
                                                   TieuDe = xml2.Element("TieuDe").Value,
                                                   NoiDung = xml2.Element("NoiDung").Value
                                               }).ToList();

            //Tách chuỗi mail nhận
            List<string> List = new List<string>();
            string chuoi1 = TxtMailNhan.Text.Trim();
            var chuoi2 = chuoi1.Split('\n');

            var getdate = DateTime.Now.ToString("dd/MM/yyyy");

            int i;
            int a = 1;
            int thanhcong = 0;
            int thatbai = 0;
            int soluong = int.Parse(TxtSoluongmail.Text);
            for (i = 0; i < soluong; i++)
            {
                foreach (var item in EmailList)
                {
                    if (run == true)
                    {
                        try
                        {
                            foreach (var item2 in chuoi2)
                            {
                                var getName = item2.Replace("\r", "");
                                // tạo một tin nhắn và thêm những thông tin cần thiết như: ai gửi, người nhận, tên tiêu đề, và có đôi lời gì cần nhắn nhủ
                                MailConfig(getName, item.UserName,item.Password);
                                thanhcong++;
                            }
                        }
                        catch (Exception)
                        {
                            thatbai++;
                            string loi = item.UserName + " " + item.Password;
                            ListError.Add(loi);
                            using (var file = new StreamWriter("ListError.txt"))
                            {
                                ListError.ForEach(v => file.WriteLine(v));
                            }
                        }
                        Invoke(new Action(() =>
                        {
                            int soLuongGui = thanhcong * int.Parse(NbThread.Text);
                            LbThanhcong.Text = soLuongGui.ToString();
                            LbThatbai.Text = thatbai.ToString();
                        }));
                    }
                    else
                        break;
                }
            }
            Invoke(new Action(() =>
            {
                button1.Enabled = true;
                BtnStop.Enabled = false;
            }));

            MessageBox.Show("Hoàn thành");
        }

        private void threadsend()
        {
            while (run == true)
            {
                SendBtn_Click();
            }
        }

        //Gửi mail đồng loạt
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            BtnStop.Enabled = true;
            for (int i = 1; i <= int.Parse(NbThread.Text); i++)
            {
                run = true;
                Thread thread = new Thread(() =>
                {
                    SendBtn_Click();
                }
                 );

                thread.IsBackground = false;
                thread.Start();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //Thread.Interrupt();
            button1.Enabled = true;
            BtnStop.Enabled = false;
            run = false;
            MessageBox.Show("Đã dừng gửi");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadForm();
            Loadmail();
            LoadContent();
        }

        //Button thêm nhiều email
        private void AddMultiMail_Click(object sender, EventArgs e)// thêm email vào danh sách
        {
            AddNhieuMail();
            LoadForm();
        }

        //Button thêm 1 email
        private void BTcheck_Click(object sender, EventArgs e)
        {
            AddMail();
            LoadForm();
        }

        //Button xóa email
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteMail();
            Loadmail();
            LoadForm();
            MessageBox.Show("Xóa thành công");
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
            Loadmail();
            LoadForm();
            MessageBox.Show("Đã xóa toàn bộ");
        }

        #region Cell Click

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowSelect = dataGridView1.CurrentCell.RowIndex;
                TxtUserName.Text = (string)dataGridView1.Rows[RowSelect].Cells[0].Value;
                TxtPassWord.Text = (string)dataGridView1.Rows[RowSelect].Cells[1].Value;
            }
            catch (Exception)
            {
                TxtUserName.Text = null;
                TxtPassWord.Text = null;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int RowSelect = dataGridView2.CurrentCell.RowIndex;
                TxtChuDe.Text = (string)dataGridView2.Rows[RowSelect].Cells[0].Value;
                TxtNoiDung.Text = (string)dataGridView2.Rows[RowSelect].Cells[1].Value;
            }
            catch (Exception)
            {
                TxtChuDe.Text = null;
                TxtNoiDung.Text = null;
            }
        }

        #endregion Cell Click

        private void GetMail()
        {
            XDocument xmlDoc = XDocument.Load("EmailList.xml");
            List<Emaillists> pics = (from xml in xmlDoc.Elements("ListMail").Elements("Email")
                                     select new Emaillists
                                     {
                                         UserName = xml.Element("UserName").Value,
                                         Password = xml.Element("Password").Value
                                     }).ToList();
        }

        private void LoadForm()
        {
            button1.Enabled = true;
            BtnStop.Enabled = false;
            RdGmail.Checked = true;
            RdOutlook.Checked = false;
            RdYahoo.Checked = false;
            List<string> lstMunicipalities = new List<string>();
            try
            {
                try
                {
                    using (XmlTextReader ListEmailFile = new XmlTextReader("EmailList.xml"))
                    {
                        DataSet ds = new DataSet();
                        ds.ReadXml(ListEmailFile);
                    }
                    XElement MailList = XElement.Load("EmailList.xml");
                    List<Emaillists> ListEmail = new List<Emaillists>();
                    foreach (XElement item in MailList.Elements())
                    {
                        ListEmail.Add(new Emaillists
                        {
                            UserName = (String)item.Attribute("UserName"),
                            Password = (String)item.Attribute("Password"),
                        });
                    }
                }
                catch (Exception)
                {
                    string s = "<ListMail></ListMail>";
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(s);
                    xdoc.Save("EmailList.xml");
                }
                try
                {
                    XElement ContentList = XElement.Load("ContentList.xml");
                    List<Emaillists> ListConTent = new List<Emaillists>();
                    foreach (XElement item in ContentList.Elements())
                    {
                        ListConTent.Add(new Emaillists
                        {
                            UserName = (String)item.Attribute("TieuDe"),
                            Password = (String)item.Attribute("NoiDung"),
                        });
                    }
                }
                catch (Exception)
                {
                    string s = "<ListContent></ListContent>";
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(s);
                    xdoc.Save("ContentList.xml");
                }
            }
            catch (Exception)
            {
            }
        }

        #region Load Data

        public void Loadmail()
        {
            try
            {
                System.Data.DataSet dataSet = new DataSet();
                dataSet.ReadXml("EmailList.xml");
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception)
            {
                dataGridView1.DataSource = "null";
            }
        }

        public void LoadContent()
        {
            try
            {
                System.Data.DataSet dataSet = new DataSet();
                dataSet.ReadXml("ContentList.xml");
                dataGridView2.DataSource = dataSet.Tables[0];
            }
            catch (Exception)
            {
                dataGridView2.DataSource = "null";
            }
        }

        #endregion Load Data

        //public void MultiAdd()
        //{
        //    //Tách chuỗi add vô list

        //    if (string.IsNullOrEmpty(TxtEmail.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập email");
        //    }
        //    else
        //    {
        //        try
        //        {
        //            string s = TxtEmail.Text.Trim();

        //            string chuoi = s.Replace("  ", " ").Trim();
        //            string chuoi2 = chuoi.Replace("\t", " ");
        //            string chuoi3 = chuoi2.Replace("\r\n", ",");
        //            var lstString = chuoi3.Split(',');
        //            foreach (var item in lstString)
        //            {
        //                var lststringCut = item.Split(' ');
        //                var Username = lststringCut[0];
        //                var user = Username.Trim();
        //                var Password = lststringCut[2];
        //                Emp oemp = new Emp(Username.ToString(), Password.ToString());
        //                Listmail.Add(oemp);
        //            }
        //            try
        //            {
        //                DataTable table = new DataTable();
        //                var columns = from t in Listmail
        //                              orderby t.UsernameMail
        //                              select new
        //                              {
        //                                  Email = t.UsernameMail,
        //                                  Password = t.PasswordMail
        //                              };
        //                dataGridView1.DataSource = columns.ToList();
        //                //Export to XML
        //                var xEle = new XElement("ListMail",
        //                    from emp in Listmail
        //                    select new XElement("Email",
        //                                   new XElement("UserName", emp.UsernameMail),
        //                                   new XElement("Password", emp.PasswordMail)
        //                               ));
        //                xEle.Save("EmailList.xml");
        //                LoadForm();
        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Đã xảy ra lỗi");
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Vui lòng nhập đúng định dạng donaltrum@gmail.com/abc123");
        //        }
        //    }
        //}

        #region AddNew

        public void AddNhieuMail()
        {
            //Tách chuỗi add vô list

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email");
            }
            else
            {
                try
                {
                    string s = TxtEmail.Text.Trim();
                    string chuoi = s.Replace("  ", " ").Trim();
                    string chuoi2 = chuoi.Replace("\t", " ");
                    string chuoi3 = chuoi2.Replace("\r\n", ",");
                    var lstString = chuoi3.Split(',');
                    foreach (var item in lstString)
                    {
                        var lststringCut = item.Split(' ');
                        var Username = lststringCut[0];
                        var Password = lststringCut[2];
                        Emp oemp = new Emp(Username.ToString(), Password.ToString());
                        Listmail.Add(oemp);
                    }
                    try
                    {
                        DataTable table = new DataTable();
                        var columns = from t in Listmail
                                      orderby t.UsernameMail
                                      select new
                                      {
                                          Email = t.UsernameMail,
                                          Password = t.PasswordMail
                                      };
                        dataGridView1.DataSource = columns.ToList();
                        //Export to XML
                        foreach (var item in Listmail)
                        {
                            try
                            {
                                XDocument xd = XDocument.Load("EmailList.xml");
                                XElement mail = new XElement("Email",
                                new XElement("UserName", item.UsernameMail),
                                new XElement("Password", item.PasswordMail)
                                );
                                xd.Element("ListMail").Add(mail);
                                xd.Save("EmailList.xml");
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }

                        Loadmail();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã xảy ra lỗi");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }
            }
        }

        public void AddMail()
        {
            XDocument xd = XDocument.Load("EmailList.xml");
            XElement mail = new XElement("Email",
                new XElement("UserName", TxtUserName.Text),
                new XElement("Password", TxtPassWord.Text)
                );
            xd.Element("ListMail").Add(mail);
            xd.Save("EmailList.xml");
            Loadmail();
        }

        public void AddContent()
        {
            XDocument xd = XDocument.Load("ContentList.xml");
            XElement mail = new XElement("ListContent",
                new XElement("TieuDe", TxtChuDe.Text),
                new XElement("NoiDung", TxtNoiDung.Text)
                );
            xd.Element("ListContent").Add(mail);
            xd.Save("ContentList.xml");
            LoadContent();
        }

        #endregion AddNew

        #region Update

        private void EditMail()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("EmailList.xml");
            foreach (XmlElement item in xd.SelectNodes("//Email"))
            {
                if (item.SelectSingleNode("UserName").InnerText == TxtUserName.Text)
                {
                    item.SelectSingleNode("UserName").InnerText = TxtUserName.Text;
                    item.SelectSingleNode("Password").InnerText = TxtPassWord.Text;
                }
            }
            xd.Save("EmailList.xml");
            Loadmail();
        }

        private void EditContent()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("ContentList.xml");
            foreach (XmlElement item in xd.SelectNodes("//ListContent"))
            {
                if (item.SelectSingleNode("TieuDe").InnerText == TxtChuDe.Text)
                {
                    item.SelectSingleNode("TieuDe").InnerText = TxtChuDe.Text;
                    item.SelectSingleNode("NoiDung").InnerText = TxtNoiDung.Text;
                }
            }
            xd.Save("ContentList.xml");
            LoadContent();
        }

        #endregion Update

        #region Delete

        private void DeleteMail()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("EmailList.xml");
            try
            {
                foreach (XmlNode item in xd.SelectNodes("ListMail/Email"))
                {
                    if (item.SelectSingleNode("UserName").InnerText == TxtUserName.Text)
                    {
                        item.ParentNode.RemoveChild(item);
                        xd.Save("EmailList.xml");
                    }
                }
            }
            catch (Exception)
            {
                //Loadmail();
            }
            Loadmail();
        }

        private void DeleteContent()
        {
            XmlDocument xd = new XmlDocument();
            xd.Load("ContentList.xml");
            try
            {
                foreach (XmlNode item in xd.SelectNodes("ListContent/ListContent"))
                {
                    if (item.SelectSingleNode("TieuDe").InnerText == TxtChuDe.Text && item.SelectSingleNode("NoiDung").InnerText == TxtNoiDung.Text)
                    {
                        item.ParentNode.RemoveChild(item);
                        xd.Save("ContentList.xml");
                    }
                }
            }
            catch (Exception)
            {
                //Loadmail();
            }
            LoadContent();
        }

        private void DeleteAll()
        {
            string s = "<ListMail></ListMail>";
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(s);
            xdoc.Save("EmailList.xml");
        }

        #endregion Delete

        private void BtnOpenloi_Click(object sender, EventArgs e)
        {
            string file = @"ListError.txt";
            Process.Start(file);
        }

        private void BtnAddContent_Click(object sender, EventArgs e)
        {
            AddContent();
            LoadContent();
        }

        private void BtnDelConTent_Click(object sender, EventArgs e)
        {
            DeleteContent();
            MessageBox.Show("Xóa thành công");
            LoadContent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBTuDong.Checked)
            {
                TxtTieude.Enabled = false;
                TxtContent.Enabled = false;
            }
            else
            {
                TxtTieude.Enabled = true;
                TxtContent.Enabled = true;
            }
        }
    }
}