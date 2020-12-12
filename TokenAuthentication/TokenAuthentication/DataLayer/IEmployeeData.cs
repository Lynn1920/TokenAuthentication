using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokenAuthentication.Models;

namespace TokenAuthentication.DataLayer
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetEmployees();
    }
}
