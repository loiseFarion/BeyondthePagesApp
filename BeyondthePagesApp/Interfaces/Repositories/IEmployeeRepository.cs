using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployess();
        Task<Employee> GetEmployeeById(int id);
    }
}
