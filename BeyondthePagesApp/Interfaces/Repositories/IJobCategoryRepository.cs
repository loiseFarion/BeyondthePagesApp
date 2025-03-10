using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Repositories
{
    public interface IJobCategoryRepository
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);

    }
}
