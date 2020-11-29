using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CITSWebApi.Models
{
    public class SalaryDTO
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<System.DateTime> Month { get; set; }
        public Nullable<System.DateTime> Year { get; set; }
        public Nullable<int> PresentDays { get; set; }
        public Nullable<int> AbsentDays { get; set; }
        public Nullable<int> HalfDays { get; set; }
        public Nullable<int> TotalPermission { get; set; }
        public Nullable<int> TotalLateDays { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public Nullable<decimal> LeaveDetect { get; set; }
        public Nullable<decimal> LateDetect { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> NetAmount { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    }
}