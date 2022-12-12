﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Enums;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Company_Tests
    {
        #region "Test Boilerplate"
        private static TestContext? _testContext;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _testContext = context;
        }
        #endregion

        [TestMethod]
        public void Company_Ctor()
        {
            Company model = new()
            {
                Id = 14,
                Kind = CompanyKind.Vendor,
                Name = "Suckers and More",
                Address = new Location()
                {
                    Id = 1,
                    LocationName = "A Place",
                    Addreesee = "Joe Gunchy",
                    AddressLine1 = "123 Main St",
                    AddressLine2 = "Floor 2",
                    AddressLine3 = "Section A",
                    AddressLine4 = "Cube 42a",
                    City = "Sacramento",
                    StateOrProvince = "CA",
                    PostalCode = "95620",
                    Kind = LocationKind.Commercial
                },
                People = new List<Person>() {
                    new Person()
                    {
                        Id =4,
                        NameFirst = "Susan",
                        NameLast = "Jones",
                        Address =null,
                        Email = "Susan.Jones@sam.co",
                        Kind = PersonKind.Primary | PersonKind.Sales,
                        MobilePhone ="+1 916-455-0432"
                    },
                    new Person()
                    {
                        Id =34,
                         NameFirst = "Peter",
                         NameLast = "Smith",
                         Address =null,
                         Email = "Peter.Smith@sam.co",
                         Kind = PersonKind.Primary | PersonKind.Receiving,
                         MobilePhone ="+1 916-455-0476"
                    }
                }
            };

            // TODO: Test Serialization
            
        }
    }
}