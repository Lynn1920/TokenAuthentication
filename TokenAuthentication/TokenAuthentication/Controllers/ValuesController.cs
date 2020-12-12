using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TokenAuthentication.DataLayer;
using TokenAuthentication.Models;

namespace TokenAuthentication.Controllers
{
    public class ValuesController : ApiController
    {
        IEmployeeData employeeData;
        public ValuesController()
        {
            employeeData = new EmployeeData();
        }
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            var emplist=employeeData.GetEmployees();
            return employeeData.GetEmployees();
        }
        [HttpPost]
        [Route("api/values/register")]
        public IHttpActionResult Register(Registration registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return null;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
