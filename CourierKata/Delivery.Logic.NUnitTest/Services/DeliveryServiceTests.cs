using Delivery.Logic.Interfaces;
using Delivery.Logic.NUnitTest.Helpers;
using Delivery.Logic.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Delivery.Logic.NUnitTest.Services
{
    [TestFixture]
    public class DeliveryServiceTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        #region Calculate Delivery Costs
        [Test]
        public void CalculateDeliveryCosts_UseMixOfParcels_GetCorrectCalculus()
        {
            // Arrange
            List<IParcel> parcels = new List<IParcel>() { ParcelHelper.GetSmallParcel(),
                ParcelHelper.GetLargeParcel(), ParcelHelper.GetMediumParcel(), ParcelHelper.GetXLParcel() };

            int expectedCosts = ParcelHelper.GetSmallParcel().ParcelCost + ParcelHelper.GetLargeParcel().ParcelCost
                + ParcelHelper.GetMediumParcel().ParcelCost + ParcelHelper.GetXLParcel().ParcelCost;

            // Act
            var actualCost = new DeliveryService().CalculateParcelDeliveryCosts(parcels);

            // Assert
            Assert.AreEqual(expectedCosts, actualCost);
        }

        [Test]
        public void CalculateDeliveryCosts_UseNoParcels_GetResult0()
        {
            // Arrange
            int expectedCost = 0;

            // Act
            var actualCost = new DeliveryService().CalculateParcelDeliveryCosts(new List<IParcel>());

            // Assert
            Assert.AreEqual(expectedCost, actualCost);
        }


        [Test]
        public void CalculateDeliveryCosts_UseSmallParcelsOnly_GetCorrectCalculus()
        {
            // Arrange
            List<IParcel> parcels = new List<IParcel>() { ParcelHelper.GetSmallParcel(),ParcelHelper.GetSmallParcel(),ParcelHelper.GetSmallParcel(),
               };

            int expectedCosts = ParcelHelper.GetSmallParcel().ParcelCost * 3;

            // Act
            var actualCost = new DeliveryService().CalculateParcelDeliveryCosts(parcels);

            // Assert
            Assert.AreEqual(expectedCosts, actualCost);
        }

        #endregion
    }
}
