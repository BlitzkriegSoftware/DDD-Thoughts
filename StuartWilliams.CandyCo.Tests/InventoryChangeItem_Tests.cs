using BlitzkriegSoftware.MsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System.Diagnostics.CodeAnalysis;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class InventoryChangeItem_Tests
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
        public void InventoryChangeItem_Serialization() {

            var model = new InventoryChangeItem()
            {
                ChangeOperationKind = StuartWilliams.CandyCo.SharedKernels.Enums.InventoryChangeOperationKind.InboundAdd,
                Quantity = 1,
                UPC = new UniversalProductCode("0 12345 54321 0")
            };

            TestJsonSerializationHelper.AssertJsonSerialization<InventoryChangeItem>(_testContext, model);
        }

    }
}
