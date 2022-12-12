using StuartWilliams.CandyCo.SharedKernels.Models;

using BlitzkriegSoftware.MsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Money_Tests
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
        public void Money_Serialization()
        {
            var model = new Money()
            {
                Amount = 34.56m,
                CurrencyInfo = new CurrencyInfo("USD")
            };

            TestJsonSerializationHelper.AssertJsonSerialization<Money>(_testContext, model);
        }
    }
}
