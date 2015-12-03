using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class TermExamDO
    {
        private string _time_sent = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        //private string _time_zone_id = "PACIFIC STANDARD TIME";

        public string time_sent { get { return _time_sent; } set { _time_sent = value.Trim(); } }

        public void SetTimeSent(DateTime timeSent)
        {
            _time_sent = timeSent.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public string term_id { get; set; }

        public string term_name { get; set; }

        public string exam_id { get; set; }

        public string description { get; set; }

        public string start_date { get; set; }

        public string end_date { get; set; }

        public string courseno { get; set; }

        public string instructor { get; set; }

        public string duration { get; set; }

        public string password { get; set; }

        public string notes { get; set; }

        public string max_attempt { get; set; }

        public string active { get; set; }
    }
}
