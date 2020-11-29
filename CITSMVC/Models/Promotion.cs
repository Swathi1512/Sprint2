using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CITSMVC.Models
{
    public class Promotion
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public string Current_Designation { get; set; }
        public string Promotional_Designation { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public byte[] Letter { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
    }
}