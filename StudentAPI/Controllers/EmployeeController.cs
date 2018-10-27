using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        Dictionary<string, string> emp = new Dictionary<string, string>();

      

        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {

            return EmployeeDataPopulator();
        }

        internal static IEnumerable<Employee> EmployeeDataPopulator()
        {
            IEnumerable<Employee> empData;

            List<Employee> data = new List<Employee>();
            for(int i=0;i<=20;i++)
            {
                Employee empIn = new Employee();
                empIn.ID = i + 1;
                empIn.Name = "Demo "+i;
                empIn.Mobile = "99998880" + i;
                empIn.Qualification = i+ " Class";
                if (i % 2 == 0)
                {
                    empIn.Gender = "Male";
                    empIn.Address = "Chennai";
                }
                else
                {
                    empIn.Gender = "Female";
                    empIn.Address = "Bangalore";
                }
                empIn.IsActive = true;

                data.Add(empIn);
            }

            empData = data.ToList();
            

            return empData.ToList();
        }

        // GET: api/Employee/5
        public IEnumerable<Employee> Get(int id)
        {
            
            IEnumerable<Employee> empData = EmployeeDataPopulator();

            IEnumerable <Employee> empResult = empData.Where( x => x.ID == id).ToList();
            return empResult;
        }
        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
