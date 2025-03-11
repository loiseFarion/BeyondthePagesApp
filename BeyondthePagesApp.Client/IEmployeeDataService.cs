using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Client
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployess();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
