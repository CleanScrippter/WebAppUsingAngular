using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppUsingAngular.Models;

namespace WebAppUsingAngular.Controllers
{
    public class EmployeesController : ApiController
    {
        // GET api/<controller>
        public List<Employee> Get()
        {
            List <Employee>  employeedeta=  new List<Employee>();
            Employee obj = new Employee { id = 0, firstName = "s", lastName = "dd", emailId = "ddd" };
            employeedeta.Add(obj);
            return employeedeta;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}