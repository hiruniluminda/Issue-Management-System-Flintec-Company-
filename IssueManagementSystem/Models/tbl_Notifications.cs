//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueManagementSystem.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tbl_Notifications
    {
        public int NotificationId { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public int EmployeeNumber { get; set; }
        public System.DateTime Date { get; set; }
        public string Dates { get; set; }
    }
}
