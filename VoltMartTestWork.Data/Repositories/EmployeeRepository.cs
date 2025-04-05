using Microsoft.EntityFrameworkCore;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Core.Models;

namespace VoltMartTestWork.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
