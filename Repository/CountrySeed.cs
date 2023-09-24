using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CountrySeed
    {
        public static void SeedAsync(RepositoryContext context)
        {
            if (!context.Countries.Any())
            {
                var country = new List<Country>
                {

                    new Country
                    {
                        Id = 1,
                        CountryCode = "234",
                        Name = "Nigeria",
                        CountryIso = "NG"
                    },
                    new Country
                    {
                        Id = 2,
                        CountryCode = "233",
                        Name = "Ghana",
                        CountryIso = "GH"
                    },
                    new Country
                    {
                        Id = 3,
                        CountryCode = "229",
                        Name = "Benin Republic",
                        CountryIso = "BN"
                    },
                    new Country
                    {
                        Id = 4,
                        CountryCode = "225",
                        Name = "Cote d'Ivoire",
                        CountryIso = "CIV"
                    }
                };
                context.Countries.AddRange(country);
                context.SaveChanges();
            }

            if (!context.CountryDetails.Any())
            {
                var countryDetails = new List<CountryDetails>
                {

                    new CountryDetails
                    {
                        Id = 1,
                        CountryId = 1,
                        Operator = "MTN Nigeria",
                        OperatorCode = "MTN NG"
                    },
                    new CountryDetails
                    {
                        Id = 2,
                        CountryId = 1,
                        Operator = "Airtel Nigeria",
                        OperatorCode = "ANG"
                    },
                    new CountryDetails
                    {
                        Id = 3,
                        CountryId = 1,
                        Operator = "9 Mobile Nigeria",
                        OperatorCode = "ETN"
                    },
                    new CountryDetails
                    {
                        Id = 4,
                        CountryId = 1,
                        Operator = "Globacom Nigeria",
                        OperatorCode = "GLO NG"
                    },
                    new CountryDetails
                    {
                        Id = 5,
                        CountryId = 2,
                        Operator = "Vodafone Ghana",
                        OperatorCode = "Vodafone GH"
                    },
                    new CountryDetails
                    {
                        Id = 6,
                        CountryId = 2,
                        Operator = "MTN Ghana",
                        OperatorCode = "MTN Ghana"
                    },
                    new CountryDetails
                    {
                        Id = 7,
                        CountryId = 2,
                        Operator = "Tigo Ghana",
                        OperatorCode = "Tigo Ghana"
                    },
                    new CountryDetails
                    {
                        Id = 8,
                        CountryId = 3,
                        Operator = "MTN Benin",
                        OperatorCode = "MTN Benin"
                    },
                    new CountryDetails
                    {
                        Id = 9,
                        CountryId = 3,
                        Operator = "Moov Benin",
                        OperatorCode = "Moov Benin"
                    },
                    new CountryDetails
                    {
                        Id = 10,
                        CountryId = 4,
                        Operator = "MTN Cote d'Ivoire",
                        OperatorCode = "MTN CIV"
                    }
                };
                context.CountryDetails.AddRange(countryDetails);
                context.SaveChanges();
            }
        }
    }
}
