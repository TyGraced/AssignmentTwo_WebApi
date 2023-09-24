using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class CountryLengthException : NotFoundException
    {
        public CountryLengthException(string phoneNumber)
            : base($"Check that the PhoneNumber: {phoneNumber} is not less than 10 digits")
        {
        }
    }
}
