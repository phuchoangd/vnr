//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MD_APPLICATIONFILES1
    {
        public MD_APPLICATIONFILES1()
        {
            this.MD_FILE_ARTIFACTS = new HashSet<MD_FILE_ARTIFACTS1>();
        }
    
        public decimal ID { get; set; }
        public decimal APPLICATIONS_ID_FK { get; set; }
        public string NAME { get; set; }
        public string URI { get; set; }
        public string TYPE { get; set; }
        public string STATE { get; set; }
        public string LANGUAGE { get; set; }
        public Nullable<decimal> LOC { get; set; }
        public decimal SECURITY_GROUP_ID { get; set; }
        public System.DateTime CREATED_ON { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_ON { get; set; }
        public string UPDATED_BY { get; set; }
    
        public virtual ICollection<MD_FILE_ARTIFACTS1> MD_FILE_ARTIFACTS { get; set; }
        public virtual MD_APPLICATIONS1 MD_APPLICATIONS { get; set; }
    }
}
