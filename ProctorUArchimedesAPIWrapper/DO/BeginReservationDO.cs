﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class BeginReservationDO
    {
        private string _time_sent = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

        public string time_sent { get { return _time_sent; } set { _time_sent = value.Trim(); } }

        public void SetTimeSent(DateTime timeSent)
        {
            _time_sent = timeSent.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        // *** MESSAGE PROPERTIES ***
        public string student_id { get; set; }

        public string reservation_id { get; set; }

        public string reservation_no { get; set; }

    }
}
