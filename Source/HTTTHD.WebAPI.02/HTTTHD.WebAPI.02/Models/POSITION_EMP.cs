//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTTTHD.WebAPI._02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class POSITION_EMP
    {
        public POSITION_EMP()
        {
            this.EMPLOYEEs = new HashSet<EMPLOYEE>();
        }
    
        public int idPOSITION { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Nullable<int> Created_by { get; set; }
        public Nullable<int> Last_update_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Last_update_date { get; set; }
    
        public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
