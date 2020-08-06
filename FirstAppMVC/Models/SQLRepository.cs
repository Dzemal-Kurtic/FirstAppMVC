using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppMVC.Models
{
    public class SQLRepository : IRepository
    {
        private readonly AppDbContext context;

        public SQLRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        public void Edit(Employee employee)
        {
            var employeeChanged = context.Employees.Attach(employee);
            employeeChanged.State = EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employees.Find(id);
        }
    }
}
