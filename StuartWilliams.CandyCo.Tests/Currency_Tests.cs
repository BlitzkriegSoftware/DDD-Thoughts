using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuartWilliams.CandyCo.SharedKernels.Lookups;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Currency_Tests
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
        public void CurencyCodeList_HasMembers() {
            Assert.IsTrue(CurencyCodeList.Iso4217.Count > 0);
        }

        [TestMethod]
        public void CurrencyInfo_IsValid_1()
        {
            var model = new CurrencyInfo("USD");
            Assert.IsTrue(model.IsValid());
        }

        [TestMethod]
        public void CurrencyInfo_IsValid_2()
        {
            var model = new CurrencyInfo("123");
            Assert.IsFalse(model.IsValid());
        }

        [TestMethod]
        public void CurrencyInfo_AreEqual()
        {
            var ci = new CurrencyInfo("USD");
            var ci2 = new CurrencyInfo("USD");
            Assert.AreEqual(ci, ci2);
        }

        [TestMethod]
        public void CurrencyInfo_AreNotEqual()
        {
            var ci = new CurrencyInfo("USD");
            var ci2 = new CurrencyInfo("BGN");
            Assert.IsFalse(ci.Equals(ci2));
        }

        [TestMethod]
        public void CurrencyInfo_HashCode() {
            var ci = new CurrencyInfo("USD");
            var actual = ci.GetHashCode();
            var expected = 2;
            Assert.AreEqual(actual, expected);

        }

    }
}
