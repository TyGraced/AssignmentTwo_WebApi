using Contracts;
using Entities.Exceptions;
using Shared.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<CountryDto> GetCountryByPhoneNumber(string phoneNumber)
        {
            // Check if the PhoneNumber is at least 10 digits
            if (phoneNumber.Length < 10) throw new CountryLengthException(phoneNumber);
            // Get Country code from PhoneNumber
            string countryCode = phoneNumber.Substring(0, 3);

            // Fetch the Country using the extracted code
            var country = await _countryRepository.GetCountryByCountryCodeAsync(countryCode);

            if (country == null) throw new CountryNotFoundException(countryCode);

            var countryDto = new CountryDto
            {
                CountryCode = country.CountryCode,
                Name = country.Name,
                CountryIso = country.CountryIso,
                CountryDetails = country.CountryDetails.Select(cd => new CountryDetailsDto
                {
                    Operator = cd.Operator,
                    OperatorCode = cd.OperatorCode
                }).ToList()
            };

            return countryDto;
        }
    }
}
