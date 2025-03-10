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

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var addEntity = await _addDbContext.Employees.AddAsync(employee);
            await _addDbContext.SaveChangesAsync();
            return addEntity.Entity;
        }
        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var foundEmployee = await _addDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if (foundEmployee != null)
            {
                foundEmployee.CountryId = employee.CountryId;
                foundEmployee.MaritalStatus = employee.MaritalStatus;
                foundEmployee.BirthDate = employee.BirthDate;
                foundEmployee.City = employee.City;
                foundEmployee.Email = employee.Email;
                foundEmployee.FirstName = employee.FirstName;
                foundEmployee.LastName = employee.LastName;
                foundEmployee.Gender = employee.Gender;
                foundEmployee.PhoneNumber = employee.PhoneNumber;
                foundEmployee.Smoker = employee.Smoker;
                foundEmployee.Street = employee.Street;
                foundEmployee.Zip = employee.Zip;
                foundEmployee.JobCategoryId = employee.JobCategoryId;
                foundEmployee.Comment = employee.Comment;
                foundEmployee.ExitDate = employee.ExitDate;
                foundEmployee.JoinedDate = employee.JoinedDate;
                foundEmployee.ImageContent = employee.ImageContent;
                foundEmployee.ImageName = employee.ImageName;

                await _addDbContext.SaveChangesAsync();
                return foundEmployee;
            }
            return null;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var foundEmployee = await _addDbContext.Employees.FirstOrDefaultAsync(x=>x.EmployeeId == employeeId);
            if (foundEmployee == null) return;
            _addDbContext.Employees.Remove(foundEmployee);
            await _addDbContext.SaveChangesAsync();
        }
    }
}
