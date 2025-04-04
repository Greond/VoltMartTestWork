using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<int>  AddEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(Employee employee);
        Task<bool> DeleteEmployeeAsync(int id);
        Task<bool> ExistsEmployee(int id);
    }
}
