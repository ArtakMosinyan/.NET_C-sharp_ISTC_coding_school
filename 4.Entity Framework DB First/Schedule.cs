//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public string MovieID { get; set; }
        public string DateTimeID { get; set; }
        public string Room { get; set; }
    
        public virtual Movie Movie { get; set; }
        public virtual Room Room1 { get; set; }
        public virtual Session Session { get; set; }
    }
}
