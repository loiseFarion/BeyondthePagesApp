using BeyondthePagesApp.Library.Domain;
using BeyondthePagesApp.Service;

namespace BeyondthePagesApp.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        protected async override Task OnInitializedAsync()
        {
            Employees = MockDataService.Employees;
        }
    }
}
