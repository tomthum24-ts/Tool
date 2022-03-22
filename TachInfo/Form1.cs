using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoc_Click(object sender, EventArgs e)
        {
            // input = TxtInput.Text;
            string chuoi = TxtInput.Text;
            
            List<string> chuoidatach = new List<string>();
            string chuoi2 = chuoi.Replace("\r\n", ",");
            var lstString = chuoi2.Split(',');
            Dictionary<string,string> chuoiSuDung = new Dictionary<string, string>();
            var chuoiNoi = "";
            foreach (var item in lstString)
            {
                Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",RegexOptions.IgnoreCase);
                Regex findDateTime = new Regex(@"\w+([/]\w+)", RegexOptions.IgnoreCase);
                //find items that matches with our pattern
                MatchCollection emailMatches = emailRegex.Matches(item);
                MatchCollection dateTimeMatches = findDateTime.Matches(item);
                StringBuilder sb = new StringBuilder();

                foreach (Match emailMatch in emailMatches)
                {
                    //sb.AppendLine(emailMatch.Value);
                    try
                    {
                        //if(dateTimeMatches != null)
                        //{
                        //    foreach (Match dateTimeMatch in dateTimeMatches)
                        //    {
                        //        string[] chuoimoi = dateTimeMatch.ToString().Split('/');
                        //        var ngay=chuoimoi[0];
                        //        var nam = "20"+chuoimoi[1];
                        //        if (int.Parse(ngay) > DateTime.Now.Month && int.Parse(nam) > DateTime.Now.Year)
                        //        {
                        //            chuoiSuDung.Add(emailMatch.ToString(), item);
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    chuoiSuDung.Add(emailMatch.ToString(), item);
                        //}
                        chuoiSuDung.Add(emailMatch.ToString(), item);
                    }
                    catch (Exception)
                    {

                    }
                }
               
            }
            // Split on one or more non-digit characters.
            string dogCsv = string.Join("\r\n", chuoiSuDung.ToArray());
            TxtOutput.Text = dogCsv;
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
