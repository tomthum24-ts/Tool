using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui_mail
{
    public class BasicInfo
    {
        public string OsVersion { get; set; }
        public string PcName { get; set; }
        public string UserName { get; set; }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Windows version: {0}\n", OsVersion);
            output.AppendFormat("PC Name : {0}\n", PcName);
            output.AppendFormat("UserName : {0}\n", UserName);
            return output.ToString();
        }
    }
}
