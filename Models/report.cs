//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class report
    {
        public int id { get; set; }
        public Nullable<int> customer { get; set; }
        public string adminMail { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual user user { get; set; }
    }
}
