using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployess();
        Task<Employee> GetEmployeeById(int id);
    }
}
