//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzureLearningWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class vJobCandidate
    {
        public int JobCandidateID { get; set; }
        public Nullable<int> BusinessEntityID { get; set; }
        public string Name_Prefix { get; set; }
        public string Name_First { get; set; }
        public string Name_Middle { get; set; }
        public string Name_Last { get; set; }
        public string Name_Suffix { get; set; }
        public string Skills { get; set; }
        public string Addr_Type { get; set; }
        public string Addr_Loc_CountryRegion { get; set; }
        public string Addr_Loc_State { get; set; }
        public string Addr_Loc_City { get; set; }
        public string Addr_PostalCode { get; set; }
        public string EMail { get; set; }
        public string WebSite { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}