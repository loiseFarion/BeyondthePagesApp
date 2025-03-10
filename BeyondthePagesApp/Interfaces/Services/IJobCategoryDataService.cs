using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
