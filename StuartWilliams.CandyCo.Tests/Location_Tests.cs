﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StuartWilliams.CandyCo.SharedKernels;
using System.Diagnostics.CodeAnalysis;

namespace DDD_thoughts_test_example
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class Location_Tests
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
        public void Location_Valid_1()
        {
            var model = new StuartWilliams.CandyCo.SharedKernels.Models.Location()
            {
                Id = 1,
                LocationName = "A Place",
                Addreesee = "Joe Gunchy",
                AddressLine1 = "123 Main St",
                AddressLine2 = "Floor 2",
                AddressLine3 = "Section A",
                AddressLine4 = "Cube 42a",
                City = "Sacramento",
                StateOrProvince = "CA",
                PostalCode = "95620",
                Kind = StuartWilliams.CandyCo.SharedKernels.Enums.LocationKind.Commercial,
                Coordinates = new StuartWilliams.CandyCo.SharedKernels.Models.GpsCoordinates()
                {
                    Confidence = 91.0m,
                    Elevation = 11m,
                    Latitude = 38.576660m,
                    Longitude = -121.495110m
                }
            };

            Assert.IsTrue(model.IsGeoCoded());
            Assert.IsTrue(model.IsLocationRecord());
            Assert.IsTrue(model.IsValidMailingAddress());
        }


        [TestMethod]
        public void Location_Invalid_1()
        {
            var model = new StuartWilliams.CandyCo.SharedKernels.Models.Location()
            {
                Id = 1,
                LocationName = "A Place",
                Addreesee = "Joe Gunchy",
                AddressLine1 = "123 Main St",
                AddressLine2 = "Floor 2",
                AddressLine3 = "Section A",
                AddressLine4 = "Cube 42a",
                City = "Sacramento",
                StateOrProvince = "CA",
                PostalCode = "95620",
                Kind = StuartWilliams.CandyCo.SharedKernels.Enums.LocationKind.Commercial
            };

            Assert.IsFalse(model.IsGeoCoded());
            Assert.IsTrue(model.IsLocationRecord());
            Assert.IsTrue(model.IsValidMailingAddress());
        }


        [TestMethod]
        public void Location_Invalid_2()
        {
            var model = new StuartWilliams.CandyCo.SharedKernels.Models.Location()
            {
                Id = 1,
                LocationName = "A Place",
                Addreesee = "Joe Gunchy",
                AddressLine1 = "123 Main St",
                AddressLine2 = "Floor 2",
                AddressLine3 = "Section A",
                AddressLine4 = "Cube 42a",
                City = "Sacramento",
                StateOrProvince = null,
                PostalCode = null,
                Kind = StuartWilliams.CandyCo.SharedKernels.Enums.LocationKind.Commercial,
                Coordinates = new StuartWilliams.CandyCo.SharedKernels.Models.GpsCoordinates()
                {
                    Confidence = 91.0m,
                    Elevation = 11m,
                    Latitude = 38.576660m,
                    Longitude = -121.495110m
                }
            };

            Assert.IsTrue(model.IsGeoCoded());
            Assert.IsTrue(model.IsLocationRecord());
            Assert.IsFalse(model.IsValidMailingAddress());
        }


        [TestMethod]
        public void Location_Invalid_3()
        {
            var model = new StuartWilliams.CandyCo.SharedKernels.Models.Location()
            {
                Id = 0,
                LocationName = "A Place",
                Addreesee = "Joe Gunchy",
                AddressLine1 = "123 Main St",
                AddressLine2 = "Floor 2",
                AddressLine3 = "Section A",
                AddressLine4 = "Cube 42a",
                City = "Sacramento",
                StateOrProvince = "CA",
                PostalCode = "95620",
                Kind = StuartWilliams.CandyCo.SharedKernels.Enums.LocationKind.Commercial,
                Coordinates = new StuartWilliams.CandyCo.SharedKernels.Models.GpsCoordinates()
                {
                    Confidence = 91.0m,
                    Elevation = 11m,
                    Latitude = 38.576660m,
                    Longitude = -121.495110m
                }
            };

            Assert.IsTrue(model.IsGeoCoded());
            Assert.IsFalse(model.IsLocationRecord());
            Assert.IsTrue(model.IsValidMailingAddress());
        }


        [TestMethod]
        public void GeoCode_IsValid()
        {
            var model = new StuartWilliams.CandyCo.SharedKernels.Models.GpsCoordinates()
            {
                Confidence = 91.0m,
                Elevation = 11m,
                Latitude = 38.576660m,
                Longitude = -121.495110m
            };

            Assert.IsTrue(model.IsValid());
        }
    }
}