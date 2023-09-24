using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class CountryDetailsConfiguration : IEntityTypeConfiguration<CountryDetails>
    {
        public void Configure(EntityTypeBuilder<CountryDetails> builder)
        {
            builder.HasData
                (
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
                );
        }
    }
}
