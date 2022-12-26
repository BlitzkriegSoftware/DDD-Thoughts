using BlitzkriegSoftware.MsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class InventoryTransferOrder_Tests
    {
        #region "Test Boilerplate"
        private static TestContext _testContext;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _testContext = context;
        }
        #endregion

        private static InventoryChangeOrder ModelMake()
        {
            return new InventoryChangeOrder()
            {
                FromCompany = 1,
                ToCompany = 4324,
                Id = 87,
                IsDeleted = false,
                ParentId = 0,
                RelatedTransactionId = 4242,
                TransferDate = DateTime.UtcNow,
                Name = "Xfer",
                Items = new List<InventoryChangeItem>() {
                            new InventoryChangeItem ()
                            {
                                 ChangeOperationKind = StuartWilliams.CandyCo.SharedKernels.Enums.InventoryChangeOperationKind.OutboundMinus,
                                  Quantity= 33,
                                   UPC = new UniversalProductCode("0 12345 54321 0")

                            },
                            new InventoryChangeItem ()
                            {
                                 ChangeOperationKind = StuartWilliams.CandyCo.SharedKernels.Enums.InventoryChangeOperationKind.OutboundMinus,
                                 Quantity = 2,
                                 UPC = new UniversalProductCode("010101010105")
                            }
                        }
            };
        }

        [TestMethod]
        public void InventoryTransferOrder_Serialization()
        {
            var model = ModelMake();
            TestJsonSerializationHelper.AssertJsonSerialization<InventoryChangeOrder>(_testContext, model);
        }

        [TestMethod]
        public void InventoryTransferOrder_Clone() {
            var model = ModelMake();
            Assert.IsTrue(model.IsValid());
            InventoryChangeOrder clone = (InventoryChangeOrder) model.Clone();
            Assert.IsFalse(clone.IsValid());
        }
    }
}
