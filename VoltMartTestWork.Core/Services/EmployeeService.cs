using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Core.Interfaces.IServices;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Core.Services
{
    internal class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetEntities();
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await _employeeRepository.GetEntityById(id);
        }
        public async Task<Employee> CreateEmployee(Employee employee)
        {
           employee.Createat = DateOnly.FromDateTime(DateTime.Today);
           return await _employeeRepository.CreateEntity(employee);
        }
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            employee.Updateat = DateOnly.FromDateTime(DateTime.Today);
            return await _employeeRepository.UpdateEntity(employee);
        }
        public async Task DeleteEmployee(Employee employee)
        {
           await _employeeRepository.DeleteEntity(employee);
        }
        public async Task DeleteEmployee(int id)
        {
            var entity = await _employeeRepository.GetEntityById(id);
            await _employeeRepository.DeleteEntity(entity);
        }
        public Task<bool> ExistsEmployee(int id)
        {
            return _employeeRepository.IsExistsEntity(id);
        }
    }
}
