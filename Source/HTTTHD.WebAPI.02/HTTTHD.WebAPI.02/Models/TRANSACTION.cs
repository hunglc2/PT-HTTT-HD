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
    
    public partial class TRANSACTION
    {
        public int idTRANSACTIONS { get; set; }
        public int idBranch { get; set; }
        public int idTRANSACTION_TYPES { get; set; }
        public int idACCOUNT { get; set; }
        public Nullable<decimal> Entered_amount { get; set; }
        public Nullable<decimal> Accounted_amount { get; set; }
        public Nullable<decimal> Fee_amount { get; set; }
        public Nullable<decimal> Tax_amount { get; set; }
        public string Currentcy_code { get; set; }
        public Nullable<decimal> Exchange_rate { get; set; }
        public Nullable<int> Created_by { get; set; }
        public Nullable<int> Last_update_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Last_update_date { get; set; }
        public Nullable<int> Approver_by { get; set; }
        public Nullable<System.DateTime> Approver_date { get; set; }
        public string Status { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual BRANCH BRANCH { get; set; }
        public virtual TRANSACTION_TYPES TRANSACTION_TYPES { get; set; }
    }
}