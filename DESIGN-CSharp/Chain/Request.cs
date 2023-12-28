using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain
{
    //提出申請
    public class ApplyRequest
    {
        public string requestType { get; set; }

        public string requestContent { get; set; }

        public int requestCount { get; set; }
    }
}
