//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MastersProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_state
    {
        public tbl_state()
        {
            this.tbl_city = new HashSet<tbl_city>();
            this.tbl_studentlistpage = new HashSet<tbl_studentlistpage>();
        }
    
        public long Sid { get; set; }
        public string Sname { get; set; }
        public long Cid { get; set; }
        public long trans_id { get; set; }
    
        public virtual ICollection<tbl_city> tbl_city { get; set; }
        public virtual tbl_country tbl_country { get; set; }
        public virtual tbl_transaction tbl_transaction { get; set; }
        public virtual ICollection<tbl_studentlistpage> tbl_studentlistpage { get; set; }
    }
}