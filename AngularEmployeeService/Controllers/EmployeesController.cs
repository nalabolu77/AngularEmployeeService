using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularEmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<AngularEmployee> Get()
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                List<AngularEmployee> angularEmployee = entites.AngularEmployees.ToList();
                return angularEmployee;
            }
        }
        public AngularEmployee Get(string code)
        {
            using (EmployeeDBEntities entites = new EmployeeDBEntities())
            {
                AngularEmployee angularEmployee = entites.AngularEmployees.FirstOrDefault(e => e.code == code);
                return angularEmployee;
            }
        }
    }
}
