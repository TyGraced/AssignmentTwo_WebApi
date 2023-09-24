using Shared.DataTransferObjects;

namespace Shared.Contracts
{
    public interface ICountryService
    {
        Task<CountryDto> GetCountryByPhoneNumber(string phoneNumber);
    }
}
