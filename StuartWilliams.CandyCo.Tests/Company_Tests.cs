using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Enums;

using BlitzkriegSoftware.MsTest;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Company_Tests
    {
        #region "Test Boilerplate"
        private static TestContext _testContext;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _testContext = context;
        }
        #endregion

        private static Company ModelMake()
        {
            Company model = new()
            {
                Id = 14,
                Kind = CompanyKind.Vendor,
                Name = "Suckers and More",
                Address = new Location()
                {
                    Id = 1,
                    Name = "A Place",
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
            return model;
        }

        [TestMethod]
        public void Company_Serialization()
        {
            var model = ModelMake();
            TestJsonSerializationHelper.AssertJsonSerialization<Company>(_testContext, model);
        }

        [TestMethod]
        public void Test_Clone()
        {
            var model = ModelMake();
            Company clone = (Company) model.Clone();
            Assert.AreEqual(0, clone.Id);
            Assert.IsFalse(clone.IsValid());
            Assert.IsTrue(model.IsValid());
        }


    }
}
