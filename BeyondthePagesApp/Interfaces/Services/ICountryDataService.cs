using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Interfaces.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}

