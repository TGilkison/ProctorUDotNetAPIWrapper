using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class ScheduleInfoExamListWithoutExamDataResponseDO
    {
        public string exam_id { get; set; }

        public string description { get; set; }

        public string start_date { get; set; }

        public string end_date { get; set; }

        public string takeitnowavailable { get; set; }
    }
}
