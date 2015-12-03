using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    public class ClientActivityReportDataResponseDO
    {
        public string Student { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string StudentNotes { get; set; }

        public string SchoolNotes { get; set; }

        public string Test { get; set; }

        public string ReservationNo { get; set; }

        public string Student_id { get; set; }

        public string CheckID { get; set; }

        public string Authenticated { get; set; }
    }
}
