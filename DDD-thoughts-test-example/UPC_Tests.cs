using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuartWilliams.CandyCo.SharedKernels;
using System.ComponentModel.DataAnnotations;

namespace DDD_thoughts_test_example
{
    [TestClass]
    public class UPC_Tests
    {
        [TestMethod]
        public void CTOR_1()
        {
            var expected = "0 12345 54321 7";

            UniversalProductCode upc = new()
            {
                CompanyCode = UniversalProductCode.CandyCoId,
                InventoryId = 54321,
            };

            var actual = upc.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}