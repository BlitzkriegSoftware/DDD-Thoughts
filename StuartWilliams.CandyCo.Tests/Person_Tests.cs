using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Enums;

using BlitzkriegSoftware.MsTest;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Person_Tests
    {
        #region "Test Boilerplate"
        private static TestContext _testContext;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _testContext = context;
        }
        #endregion

        [TestMethod]
        public void Person_Serialization()
        {
            var model = new Person()
            {
                Id = 1,
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
                Email = "Joe.Gunchy@sac.org",
                Kind = PersonKind.Sales,
                MobilePhone = "+1 916-455-1234",
                OtherPhone = "+1 916-455-3425",
                NameFirst = "Joe",
                NameLast = "Guncy"
            };

            TestJsonSerializationHelper.AssertJsonSerialization<Person>(_testContext, model);
        }

    }
}
