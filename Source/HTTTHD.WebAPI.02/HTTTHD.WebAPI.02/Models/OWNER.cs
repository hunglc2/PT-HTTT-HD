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
    
    public partial class OWNER
    {
        public OWNER()
        {
            this.BRANCHes = new HashSet<BRANCH>();
        }
    
        public int idOWNER { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> last_update_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> last_update_date { get; set; }
    
        public virtual ICollection<BRANCH> BRANCHes { get; set; }
    }
}
