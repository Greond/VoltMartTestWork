using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using System.Reflection;
using VoltMartTestWork.Core.Models;
using VoltMartTestWork.Data;
using VoltMartTestWork.Data.Repositories;
using Xunit;

namespace VoltMartTestWork.Tests.Data
{
    public class EmployeeRepositoryTests
    {
        private Mock<AppDbContext> _dbContextMock;
        private EmployeeRepository _employeeRepository;

        public EmployeeRepositoryTests()
        {
            Setup();
        }
        [Fact]
        public async Task AddAsync_ValidEmployee_ReturnsAddedEmployee()
        {
            //Arrange
            var newEmployee = GetTestEmployeeObject();

            var employeeDbSetMock = new Mock<DbSet<Employee>>();
            //вернёт db.Set<Employee>()
            _dbContextMock.Setup(db => db.Set<Employee>())
                .Returns(employeeDbSetMock.Object);
            // вернёт mewEmployee обьект
            _dbContextMock.Setup(dbSet => dbSet.AddAsync(newEmployee, default))
                .ReturnsAsync((EntityEntry<Employee>)null);
            //Act
            var result = await _employeeRepository.CreateEntity(newEmployee);
            //Assert
            Assert.NotNull(result);
            Assert.Equal(newEmployee, result);
        }



        //sub methods
        public void Setup()
        {
            _dbContextMock = new Mock<AppDbContext>(new DbContextOptions<AppDbContext>());
            _employeeRepository = new EmployeeRepository(_dbContextMock.Object);
        }

        private Employee GetTestEmployeeObject()
        {
            Employee employee = new Employee();
            employee.Firstname = "test";
            employee.Lastname = "test";
            employee.Isworking = true;
            employee.Birthday = DateOnly.FromDateTime(DateTime.Today);
            return employee;
        }
    }
}
