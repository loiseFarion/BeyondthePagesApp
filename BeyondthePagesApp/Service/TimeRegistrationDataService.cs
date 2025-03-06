using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Interfaces.Services;
using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Service
{
    public class TimeRegistrationDataService : ITimeRegistrationDataService
    {
        private readonly ITimeRegistrationRepository _timeRegistrationRepository;

        public TimeRegistrationDataService(ITimeRegistrationRepository timeRegistrationRepository)
        {
            _timeRegistrationRepository = timeRegistrationRepository;
        }

        public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
        {
            var timeRegistrationForEmployee = await _timeRegistrationRepository.GetTimeRegistrationsForEmployee(employeeId);
            return timeRegistrationForEmployee;
        }

        public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
        {
            return await _timeRegistrationRepository.GetPagedTimeRegistrationsForEmployee(employeeId, pageSize, start);
        }

        public async Task<int> GetTimeRegistrationCountForEmployeeId(int employeeId)
        {
            return await _timeRegistrationRepository.GetTimeRegistrationCountForEmployeeId(employeeId);
        }
    }
}
