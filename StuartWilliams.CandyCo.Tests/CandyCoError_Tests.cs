using BlitzkriegSoftware.MsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class CandyCoError_Tests
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
        public void CandyCoError_Serializatioin() {
            CandyCoError model = new()
            {
                ErrorCode = "xyz",
                ErrorMessage = "Error Message",
                Exception = null
            };
            TestJsonSerializationHelper.AssertJsonSerialization<CandyCoError>(_testContext, model);
        }

    }
}
