using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Core.Interfaces.IServices;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Core.Services
{
    public class EmployeeService : IEmployeeService
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
            if(ValidateEmployee(employee))
           employee.Createat = DateOnly.FromDateTime(DateTime.Today);
           return await _employeeRepository.CreateEntity(employee);
        }
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            if(ValidateEmployee(employee))
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
        private bool ValidateEmployee(Employee employee)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(employee);
            bool isValid = Validator.TryValidateObject(employee, context, results, true);
            if (!isValid)
            {
                // Отображаем ошибки валидации
                string errorMessage = string.Join(Environment.NewLine, results.Select(v => v.ErrorMessage));
                throw new Exception(errorMessage);
            }
            return true;
        }
    }
}
