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
    
    public partial class ErrorLog
    {
        public int ErrorLogID { get; set; }
        public System.DateTime ErrorTime { get; set; }
        public string UserName { get; set; }
        public int ErrorNumber { get; set; }
        public Nullable<int> ErrorSeverity { get; set; }
        public Nullable<int> ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public Nullable<int> ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
    }
}
