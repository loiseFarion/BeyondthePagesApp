using BeyondthePagesApp.Data;
using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace BeyondthePagesAdd.Repositories
{
    public class TimeRegistrationRepository : ITimeRegistrationRepository
    {
        private readonly AddDbContext _addDbContext;

        public TimeRegistrationRepository(IDbContextFactory<AddDbContext> DbFactory)
        {
            _addDbContext = DbFactory.CreateDbContext();
        }

        public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
        {
            var timeRegistrationForEmployee = await _addDbContext.TimeRegistrations
                                      .Where(t => t.EmployeeId == employeeId)
                                      .OrderBy(t => t.StartTime)
                                      .ToListAsync();
            return timeRegistrationForEmployee;
        }


        public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
        {
            return await _addDbContext.TimeRegistrations.Where(t => t.EmployeeId == employeeId).OrderBy(t => t.StartTime).Skip(start).Take(pageSize).ToListAsync();
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _addDbContext.TimeRegistrations.Where(t => t.EmployeeId == employeeId).CountAsync();
        }

    }
}
