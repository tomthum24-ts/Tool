using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gui_mail
{
    public partial class AddMail : Form
    {
        public AddMail()
        {
            InitializeComponent();
        }
        public class Emp
        {
            public string UsernameMail { get; set; }
            public string PasswordMail { get; set; }
            public Emp( string UsernameMail, string PasswordMail)
            {

                this.UsernameMail = UsernameMail;
                this.PasswordMail = PasswordMail;
            }
        }
        private void AddMultiMail_Click(object sender, EventArgs e)
        {
            //Tách chuỗi add vô list
            List<Emp> Listmail = new List<Emp>();
            string s = TxtEmail.Text;
            string chuoi2 = s.Replace("\r\n", ",");
            var lstString = chuoi2.Split(',');
            foreach (var item in lstString)
            {
                var lststringCut = item.Split('/');
                var Username = lststringCut[0];
                var Password = lststringCut[1];
                Emp oemp = new Emp( Username.ToString(), Password.ToString());
                Listmail.Add(oemp);
            }
            //Khởi tạo bảng và truyền dữ liệu vào bảng
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
            var xEle = new XElement("ListMail",
                from emp in Listmail
                select new XElement("Email",
                               new XElement("UserName", emp.UsernameMail),
                               new XElement("Password", emp.PasswordMail)
                           ));

            xEle.Save("EmailList.xml");
        }

        private void AddMail_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"EmailList.xml");
            dataGridView1.DataSource = dataSet.Tables[0];

            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 600000;
        }
    }
}
