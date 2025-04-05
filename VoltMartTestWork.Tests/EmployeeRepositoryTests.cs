using Moq;
using Xunit;
using VoltMartTestWork.Data;
using VoltMartTestWork.Data.Repositories;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Tests
{
    public class EmployeeRepositoryTests
    {
        [Fact]
        public async Task CreateData()
        {
            //Arrange
            AppDbContext appDbContext = new AppDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(appDbContext);
            Employee testEmployee = GetTestDataObject();
            //Act 
            Employee result = await employeeRepository.AddEmployeeAsync(testEmployee);
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetData()
        {
            //Arrange
            AppDbContext appDbContext = new AppDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(appDbContext);
            //Act 
            IEnumerable<Employee> result =  await employeeRepository.GetEmployees();
            //Assert
            Assert.NotEmpty(result);
        }
        [Fact]
        public async Task UpdateData()
        {
            //Arrange
            AppDbContext appDbContext = new AppDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(appDbContext);

            Employee testEmployee = GetTestDataObject();
            //получем этот созданный обьект 
            Employee modifiedEmployee = await employeeRepository.AddEmployeeAsync(testEmployee);
            if (modifiedEmployee == null)
            {
                Assert.Fail("Fail add data object into table");
            }
            //изменяем свойства этого обьекта 
            modifiedEmployee.Firstname = "tested";
            modifiedEmployee.Lastname = "tested";
            modifiedEmployee.Ismarried = false;
            modifiedEmployee.Birthday = DateOnly.FromDateTime(new DateTime(2021, 11, 11));
            //Act
            Employee result = await employeeRepository.UpdateEmployeeAsync(modifiedEmployee);
            //Assert
            Assert.Contains("tested",result.Firstname);
            Assert.Contains("tested",result.Lastname);
            Assert.False(result.Ismarried);
            Assert.Equal(DateOnly.FromDateTime(new DateTime(2021, 11, 11)), result.Birthday);
            Assert.NotNull(testEmployee.Updateat);

        }
        [Fact]
        public async Task DeleteData()
        {
            //Arrange
            AppDbContext appDbContext = new AppDbContext();
            EmployeeRepository employeeRepository = new EmployeeRepository(appDbContext);

            Employee testEmployee = GetTestDataObject();
            //получем этот созданный обьект 
            Employee employee = await employeeRepository.AddEmployeeAsync(testEmployee);
            if (employee == null)
            {
                Assert.Fail("Fail add data object into table");
            }
            //Act
            bool result = await employeeRepository.DeleteEmployeeAsync(employee.Id);
            //Assert 
            Assert.True(result);
            Assert.Null(await employeeRepository.GetEmployeeById(employee.Id));
        }

        private Employee GetTestDataObject()
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
