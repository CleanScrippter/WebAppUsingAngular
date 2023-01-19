using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppUsingAngular.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
    }
    public class ListEmployee
    {
        public List<Employee> Employee { get; set; }
    }
}