using BeyondthePagesApp.Client;
using BeyondthePagesApp.Interfaces.Services;
using BeyondthePagesApp.Library.Domain;
using BeyondthePagesApp.Library.Model;
using BeyondthePagesApp.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BeyondthePagesApp.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public List<TimeRegistration> TimeRegistrations { get; set; } = [];
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Inject]
        public ITimeRegistrationDataService? TimeRegistrationDataService { get; set; }

        private float itemHeight = 50;

        protected IQueryable<TimeRegistration>? itemsQueryable;

        protected int queryableCount = 0;

        public PaginationState pagination = new() { ItemsPerPage = 10 };

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeById(EmployeeId);
            //TimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId);
            itemsQueryable = (await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId)).AsQueryable();
            queryableCount = itemsQueryable.Count();

            if(Employee.Longitude.HasValue && Employee.Latitude.HasValue)
            {
                MapMarkers = new List<Marker>
                {
                    new Marker{Description=$"{Employee.FirstName} {Employee.LastName}", ShowPopup=false, X = Employee.Longitude.Value, Y = Employee.Latitude.Value },
                };
            }
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }

        public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationCountForEmployeeId(EmployeeId);
            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItens = await TimeRegistrationDataService.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);
            
            return new ItemsProviderResult<TimeRegistration>(listItens, totalNumberOfTimeRegistrations);
        }
    }
}
