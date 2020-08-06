using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppMVC.Models
{
    public interface IRepository
    {
        void Add(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        void Edit(Employee employee);
        void Delete(int id);
    }
}
