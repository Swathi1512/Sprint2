using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CITSMVC.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<int> Attend { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.TimeSpan> In_Time { get; set; }
        public Nullable<System.TimeSpan> Out_Time { get; set; }
        public string Permission { get; set; }
        public string IsLate { get; set; }
        public string Half { get; set; }
        public string Notes { get; set; }
        public string App_User { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    }
}