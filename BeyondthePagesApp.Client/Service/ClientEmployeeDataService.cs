using BeyondthePagesApp.Client.Helper;
using BeyondthePagesApp.Library.Domain;
using Blazored.LocalStorage;
using Microsoft.VisualBasic;
using System.Text.Json;

namespace BeyondthePagesApp.Client.Service
{
    public class ClientEmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient? _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public ClientEmployeeDataService (HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }
        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployess()
        {
            bool employeeExpirationExists = await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeesListExpirationKey);
            if (employeeExpirationExists)
            {
                DateTime employeeListExpiration = await _localStorageService.GetItemAsync<DateTime>(LocalStorageConstants.EmployeesListExpirationKey);
                if(employeeListExpiration>DateTime.Now)// FROM LOCAL STORAGE
                {
                    if(await _localStorageService.ContainKeyAsync(LocalStorageConstants.EmployeesListKey))
                    {
                        return await _localStorageService.GetItemAsync<List<Employee>>(LocalStorageConstants.EmployeesListKey);
                    }
                }
            }

            var list = await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(await _httpClient.GetStreamAsync("/api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });     
            await _localStorageService.SetItemAsync(LocalStorageConstants.EmployeesListKey, list);
            await _localStorageService.SetItemAsync(LocalStorageConstants.EmployeesListExpirationKey, DateTime.Now.AddMinutes(1));
            return list;
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
