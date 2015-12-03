using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class BlueBirdExamDO
    {
        private string _time_sent = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        private string _time_zone_id = "PACIFIC STANDARD TIME";

        public string time_sent { get { return _time_sent; } set { _time_sent = value.Trim(); } }

        public void SetTimeSent(DateTime timeSent)
        {
            _time_sent = timeSent.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public string student_id { get; set; }

        public string user_id { get; set; }

        public string user_password { get { return user_password; } set { user_password = value.Trim(); } }

        public string last_name { get { return last_name; } set { last_name = value.Trim(); } }

        public string first_name { get { return first_name; } set { first_name = value.Trim(); } }

        public string address1 { get { return address1; } set { address1 = value.Trim(); } }

        public string address2 { get { return address2; } set { address2 = value.Trim(); } }

        public string city { get { return city; } set { city = value.Trim(); } }

        public string state { get { return state; } set { state = value.Trim(); } }

        public string zipcode { get { return zipcode; } set { zipcode = value.Trim(); } }

        public string country { get { return country; } set { country = value.Trim(); } }

        public string phone1 { get { return phone1; } set { phone1 = value.Trim(); } }

        public string phone2 { get { return phone2; } set { phone2 = value.Trim(); } }

        public string email { get { return email; } set { email = value.Trim(); } }

        public string time_zone_id { get { return _time_zone_id; } set { _time_zone_id = value.Trim(); } }

        public string notify { get; set; }

        public string exam_id { get; set; }

        public string course_id { get; set; }

        public string description { get { return description; } set { description = value.Trim(); } }

        public string active_date { get; set; }

        public string end_date { get; set; }

        public string duration { get; set; }

        public string instructor { get; set; }

        public string course_no { get; set; }

        public string exam_password { get { return exam_password; } set { exam_password = value.Trim(); } }

        public string notes { get; set; }

    }
}
