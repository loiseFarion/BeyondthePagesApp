using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);

    }
}
