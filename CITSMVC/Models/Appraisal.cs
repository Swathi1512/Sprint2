using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CITSMVC.Models
{
    public class Appraisal
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Reason { get; set; }
        public byte[] Letter { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    }
}