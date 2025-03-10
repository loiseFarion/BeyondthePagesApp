using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Interfaces.Services;
using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Service
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeDataService(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _employeeRepository = employeeRepository;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        public EmployeeDataService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployess()
        {
            return await _employeeRepository.GetAllEmployess();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }
        public async Task UpdateEmployee(Employee employee)
        {
            if (employee.ImageContent != null)
            {
                string currentUrl = _httpContextAccessor.HttpContext.Request.Host.Value;
                var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{employee.ImageName}";
                var fileStream = System.IO.File.Create(path);
                fileStream.Write(employee.ImageContent, 0, employee.ImageContent.Length);
                fileStream.Close();

                employee.ImageName = $"https://{currentUrl}/uploads/{employee.ImageName}";
            }

            await _employeeRepository.UpdateEmployee(employee);
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}
