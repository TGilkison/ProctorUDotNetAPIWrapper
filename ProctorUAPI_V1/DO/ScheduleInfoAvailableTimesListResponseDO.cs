using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class ScheduleInfoAvailableTimesListResponseDO
    {
        public string time_sent { get; set; }

        public string response_code { get; set; }

        public string message { get; set; }

        public List<ScheduleInfoAvailableTimesListDataResponseDO> data { get; set; }
    }
}
