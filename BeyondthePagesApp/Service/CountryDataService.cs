using BeyondthePagesApp.Interfaces.Repositories;
using BeyondthePagesApp.Interfaces.Services;
using BeyondthePagesApp.Library.Domain;

namespace BeyondthePagesApp.Service
{
    public class CountryDataService : ICountryDataService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryDataService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            return await _countryRepository.GetCountryById(countryId);
        }
    }
}
