using BeyondthePagesApp.Data;
using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace BeyondthePagesApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AddDbContext _addDbContext;

        public EmployeeRepository(IDbContextFactory<AddDbContext> DbFactory)
        {
            _addDbContext = DbFactory.CreateDbContext();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployess()
        {
            return await _addDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _addDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);
        }
    }
}
