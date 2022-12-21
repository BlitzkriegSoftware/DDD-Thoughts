using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class UPC_Tests
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
            upc.CheckSumUpdate();

            var actual = upc.CheckSum;

            _testContext?.WriteLine($"{upc}, {expected}, {(expected.Equals(expected) ? "==" : "!=")} {actual}");

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(upc.IsValid());
        }

        [TestMethod]
        public void UPC_Equal()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 54321,
            };
            upc.CheckSumUpdate();

            UniversalProductCode upc2 = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 54321,
            };
            upc2.CheckSumUpdate();

            Assert.IsTrue(upc.Equals(upc2));
        }

        [TestMethod]
        public void UPC_Bad_1()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 54321,
            };
            Assert.IsTrue(upc.IsValid());
        }

        [TestMethod]
        public void UPC_Bad_2()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 65978,
            };
            Assert.IsFalse(upc.IsValid());
        }

        [TestMethod]
        public void UPC_Bad_3()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 65978,
            };
            upc.CheckSumUpdate();

            Assert.IsTrue(upc.IsValid());
        }

        [TestMethod]
        public void Equals_Bad_1()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 65978,
            };
            upc.CheckSumUpdate();

            object o = new();

            Assert.IsFalse(upc.Equals(o));
        }

        [TestMethod]
        public void Equals_Bad_2()
        {
            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 65978,
            };
            upc.CheckSumUpdate();

            UniversalProductCode upc2 = new("036000241457");

            Assert.IsFalse(upc.Equals(upc2));
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

        [DataTestMethod]
        [DataRow("012345543210", 58376)]
        [DataRow("310742023497", 8408)]
        [DataRow("036000241457", 54001)]
        [DataRow("010101010105", 9351)]
        public void UP_CheckSum(string upcText, int expected)
        {
            _testContext?.WriteLine($"{upcText}, {expected}");
            UniversalProductCode upc = new(upcText);
            var actual = upc.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

    }
}