//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Attendance_Automation.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Attendance
    {
        public int AttendanceID { get; set; }
        public Nullable<int> PersonelID_FK { get; set; }
        public string AttendanceDate { get; set; }
        public string Enter_Time { get; set; }
        public string Description { get; set; }
        public string Date_Submit { get; set; }
        public string Leave_Time { get; set; }
    
        public virtual Tbl_Personels Tbl_Personels { get; set; }
    }
}
