using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoltMartTestWork.Core.Interfaces;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext dbContext;
        public EmployeeRepository(AppDbContext _dbcontext)
        {
            dbContext = _dbcontext ?? throw new ArgumentNullException(nameof(_dbcontext));
        }
        public async Task<List<Employee>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await dbContext.Employees.FindAsync(id);
        }
        public async Task<int> AddEmployeeAsync(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            try
            {
                // изменяем Createat
                employee.Createat = DateOnly.FromDateTime(DateTime.Now);
                //операция в бд
                await dbContext.Employees.AddAsync(employee);
                return await dbContext.SaveChangesAsync();
               
            }
            catch
            (DbUpdateException ex)  
            {
                throw new DbUpdateException(ex.Message);
            }
        }
        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            if (!await ExistsEmployee(employee.Id))
            {
                throw new KeyNotFoundException($"Employee with ID {employee.Id} not found.");
            }
            try
            {
                //изменяем updateat 
                employee.Updateat = DateOnly.FromDateTime(DateTime.Now);
                //операция в бд
                dbContext.Employees.Entry(employee).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
                return employee;
            }
            catch
            (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message);
            }
        }
        public async Task<bool> DeleteEmployeeAsync(int id)
        {
            if (!await ExistsEmployee(id))
            {
                throw new KeyNotFoundException($"Employee with ID {id} not found.");
            }
            try
            {
                Employee employee = await dbContext.Employees.FindAsync(id);
                dbContext.Employees.Remove(employee);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch(DbUpdateException ex)
            {
                throw new DbUpdateException($"Failed update DB. Exception messege: {ex.Message}");
            }
        }
        public async Task<bool> ExistsEmployee(int id)
        {
            return await dbContext.Employees.AllAsync(e => e.Id == id);
        }
    }
}
