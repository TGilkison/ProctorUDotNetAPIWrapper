using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.DO
{
    [Serializable]
    public class StudentReservationListDataResponseDO
    {
        [Display(Name = "Reservation Number")]
        public string reservation_no { get; set; }

        [Display(Name = "Reservation ID")]
        public string reservation_id { get; set; }

        [Display(Name = "Exam ID")]
        public string exam_id { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "Course Number")]
        public string courseno { get; set; }

        [Display(Name = "Instructor")]
        public string instructor { get; set; }

        [Display(Name = "Start Date")]
        public string start_date { get; set; }

        [Display(Name = "Test")]
        public string test { get; set; }

        [Display(Name = "Escalated")]
        public string escalated { get; set; }

        [Display(Name = "Launch URL")]
        public string launch_url { get; set; }

    }
}
