using BeyondthePagesApp.Data;
using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace BeyondthePagesApp.Repositories
{
    public class JobCategoryRepository:IJobCategoryRepository,IDisposable
    {
        private readonly AddDbContext _addDbContext;

        public JobCategoryRepository(IDbContextFactory<AddDbContext> DbFactory)
        {
            _addDbContext = DbFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _addDbContext.Dispose();
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await Task.FromResult(_addDbContext.JobCategories);
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await _addDbContext.JobCategories.FirstOrDefaultAsync(c => c.JobCategoryId == jobCategoryId);
        }

    }
}
