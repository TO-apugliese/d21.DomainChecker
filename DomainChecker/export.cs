using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GetActicePages
{
    class export
    {
        public string domain { get; set; }
        public string adress { get; set; }
        public PingReply pingReply { get; set; }
    }
}
