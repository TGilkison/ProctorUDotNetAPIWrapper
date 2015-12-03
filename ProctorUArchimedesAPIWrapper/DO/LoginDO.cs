using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class LoginDO
    {
        private string _time_sent = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        private string _update = "False";
        //private string _time_zone_id = "PACIFIC STANDARD TIME";

        public string time_sent { get { return _time_sent; } set { _time_sent = value.Trim(); } }

        public void SetTimeSent(DateTime timeSent)
        {
                _time_sent = timeSent.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public string student_id { get; set; }

        public string last_name { get { return last_name; } set { last_name = value.Trim(); } }

        public string first_name { get { return first_name; } set { first_name = value.Trim(); } }

        public string email { get { return email; } set { email = value.Trim(); } }

        public string time_zone_id { get; set; }

        public string url_return { get { return url_return; } set { url_return = value.Trim(); } }

        public string update { get; set; }

        public void SetUpdate(bool updateInformation)
        {
            _update = updateInformation.ToString();
        }

    }
}
