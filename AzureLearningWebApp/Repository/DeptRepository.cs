using AzureLearningWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureLearningWebApp.Repository
{
    public class DeptRepository
    {
        public static List<Dept> GetDepts()
        {
            List<Dept> list = new List<Dept>();
            list.Add(new Dept() { Id = 1, Name = "WeChat", Remark = "WeChat" });
            list.Add(new Dept() { Id = 2, Name = "FaceBook", Remark = "FaceBook" });
            list.Add(new Dept() { Id = 3, Name = "Google", Remark = "Google" });
            list.Add(new Dept() { Id = 4, Name = "QQ", Remark = "QQ" });
            return list;
        }
    }
}