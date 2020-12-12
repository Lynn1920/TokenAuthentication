using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokenAuthentication.Models;

namespace TokenAuthentication.DataLayer
{
    public class EmployeeData : IEmployeeData
    {
        EmployeeContext emloyeeContext;
        public EmployeeData()
        {
            emloyeeContext = new EmployeeContext();
        }
        public IEnumerable<Employee> GetEmployees()
        {
            var val= emloyeeContext.employees.ToList();
            return emloyeeContext.employees.ToList() ;
        }
    }
}