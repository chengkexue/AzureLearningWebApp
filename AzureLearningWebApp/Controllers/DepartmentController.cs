using AzureLearningWebApp.Models;
using AzureLearningWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AzureLearningWebApp.Controllers
{
    public class DepartmentController : ApiController
    {
        //public string Get()
        //{
        //    return "Welcome To Web API";
        //}
        //public List<string> Get(int Id)
        //{
        //    return new List<string> {
        //        "Hello1",
        //        "Welcome To Web API"
        //    };
        //}
        /// <summary>
        /// Get All Dept
        /// </summary>
        /// <returns>All Dept List</returns>
        public List<Dept> GetAll()
        {
            return DeptRepository.GetDepts();
        }

        /// <summary>
        /// Get a specify Dept
        /// </summary>
        /// <param name="Id">The Dept id</param>
        /// <returns>A specify Dept</returns>
        public Dept GetDeptById(int id)
        {
            var dept = DeptRepository.GetDepts().Where(m => m.Id.Equals(id)).FirstOrDefault();
            if (dept != null)
            {
                dept.Name = "Microsoft";
                dept.Remark = "Microsoft";
            }
            return dept;
        }
    }
}
