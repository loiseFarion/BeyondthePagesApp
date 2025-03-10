using BeyondthePagesApp.Data;
using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace BeyondthePagesApp.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AddDbContext _addDbContext;
        public CountryRepository(IDbContextFactory<AddDbContext> DbFactory)
        {
            _addDbContext = DbFactory.CreateDbContext();
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await Task.FromResult(_addDbContext.Countries);
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _addDbContext.Countries.FirstOrDefaultAsync(c => c.CountryId == countryId);
        }
    }
}
