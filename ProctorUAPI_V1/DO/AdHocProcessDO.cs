using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class AdHocProcessDO
    {
        private string _time_sent = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

        public string time_sent { get { return _time_sent; } set { _time_sent = value.Trim(); } }

        public void SetTimeSent(DateTime timeSent)
        {
            _time_sent = timeSent.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        // *** MESSAGE PROPERTIES ***
        public string student_id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string zipcode { get; set; }

        public string country { get; set; }

        public string phone1 { get; set; }

        public string phone2 { get; set; }

        public string phone3 { get; set; }

        public string email { get; set; }

        public string time_zone_id { get; set; }

        public string description { get; set; }

        public string duration { get; set; }

        public string notes { get; set; }

        public string start_date { get; set; }

        public string reservation_id { get; set; }

        public string reservation_no { get; set; }

        public string comments { get; set; }

        public string takeitnow { get; set; }

        public string url_return { get; set; }

        public string notify { get; set; }

    }
}
