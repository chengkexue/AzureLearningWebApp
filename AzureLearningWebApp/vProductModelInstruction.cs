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
    
    public partial class vProductModelInstruction
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<decimal> SetupHours { get; set; }
        public Nullable<decimal> MachineHours { get; set; }
        public Nullable<decimal> LaborHours { get; set; }
        public Nullable<int> LotSize { get; set; }
        public string Step { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
