using Entities;

namespace Contracts
{
    public interface ICountryRepository
    {
        Task<Country> GetCountryByCountryCodeAsync(string countryCode);
    }
}
