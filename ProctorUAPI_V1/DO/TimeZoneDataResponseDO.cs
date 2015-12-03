using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class TimeZoneDataResponseDO
    {
        public string TimeZoneNo { get; set; }

        public string GMTOffset { get; set; }

        public string DST { get; set; }

        public string Id { get; set; }

        public string DisplayName { get; set; }
    }
}
