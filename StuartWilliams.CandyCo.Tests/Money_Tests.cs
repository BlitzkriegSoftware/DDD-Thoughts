using StuartWilliams.CandyCo.SharedKernels.Models;

using BlitzkriegSoftware.MsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using StuartWilliams.CandyCo.SharedKernels.Lookups;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Money_Tests
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
        public void Money_Serialization()
        {
            var model = new Money()
            {
                Amount = 34.56m,
                CurrencyInfo = new CurrencyInfo("USD")
            };

            TestJsonSerializationHelper.AssertJsonSerialization<Money>(_testContext, model);
        }

        [TestMethod]
        public void Money_Format()
        {
            foreach(var ci in CurencyCodeList.Iso4217.Values)
            {
                var m = new Money(123.4567m, ci);
                _testContext?.WriteLine($"{ci} -> {m}");
            }
        }

        [TestMethod]
        public void Money_Equals()
        {
            var m = new Money(123.4567m, "USD");
            var m2 = new Money(123.4567m, "USD");
            Assert.IsTrue(m.Equals(m2));
        }

        [TestMethod]
        public void Money_HashCode()
        {
            var m = new Money(123.4567m, "USD");
            var expected = 1496709;
            var actual = m.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

    }
}
