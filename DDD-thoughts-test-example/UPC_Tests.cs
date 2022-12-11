using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using StuartWilliams.CandyCo.SharedKernels;
using System.ComponentModel.DataAnnotations;

namespace DDD_thoughts_test_example
{
    [TestClass]
    public class UPC_Tests
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
        public void UPC_ToString()
        {
            var expected = "0 12345 54321 0";

            UniversalProductCode upc = new(expected);

            var actual = upc.ToString();

            _testContext?.WriteLine($"{expected}, {actual}");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UPC_CheckDigit_1()
        {
            var expected = 0;
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 54321,
            };
            var actual = upc.CheckSum;

            _testContext?.WriteLine($"{upc}, {expected}, {(expected.Equals(expected) ? "==" : "!=")} {actual}");

            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("012345543210",0)]
        [DataRow("310742023497",7)]
        [DataRow("036000241457",7)]
        [DataRow("010101010105",5)]
        public void UPC_CheckDigit_2(string upcText, int expected)
        {
            _testContext?.WriteLine($"{upcText}, {expected}");
            UniversalProductCode upc = new(upcText);
            var actual = upc.CheckSum;
            Assert.AreEqual(expected, actual);
        }


    }
}