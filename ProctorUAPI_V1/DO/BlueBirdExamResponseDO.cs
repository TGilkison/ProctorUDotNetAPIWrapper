using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class BlueBirdExamResponseDO
    {
        private string _url = String.Empty;

        public string message { get; set; }

        public string response_code { get; set; }

        public string time_sent { get; set; }

        public string url
        {
            get
            {
                string url = String.Empty;
                if (response_code == "1")
                {
                    _url = message;
                }
                return _url;
            }

        }
    }
}
