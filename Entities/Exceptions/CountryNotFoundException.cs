using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class CountryNotFoundException : NotFoundException
    {
        public CountryNotFoundException(string countryCode)
            : base($"The country with code: {countryCode} doesn't exist in the database. " +
                  $"Ensure the first 3 digits are the countrycode")
        {
        }
    }
}
