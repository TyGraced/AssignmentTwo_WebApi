using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly RepositoryContext _context;

        public CountryRepository(RepositoryContext context)
        {
            _context = context;
        }

        public async Task<Country> GetCountryByCountryCodeAsync(string countryCode)
        {
            // Example using LINQ to query the in-memory database
            var countries = _context.Countries.ToList();
            var countryDetails = _context.CountryDetails.ToList();


            var country = await _context.Countries.FirstOrDefaultAsync(c => c.CountryCode == countryCode);
            return country;
        }
    }
}
