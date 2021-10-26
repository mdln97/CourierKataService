using Delivery.Logic.Enums;
using Delivery.Logic.Models;
using NUnit.Framework;
using System;

namespace Delivery.Logic.NUnitTest.Models
{
    [TestFixture]
    public class ParcelTests
    {
        [SetUp]
        public void Setup()
        {

        }

        #region Parcel creation

        [Test]
        // invalid length
        [TestCase(-1, 1, 1)]
        // invalid width
        [TestCase(1, 0, 1)]
        // invalid height
        [TestCase(1, 1, -1)]
        // all invalid
        [TestCase(-1, 0, -1)]
        public void CreateParcel_UseInvalidDimensionValues_ThrowsArgumentException(int length, int width, int height)
        {
            // Arrange 

            // Act
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Parcel(length, width, height));
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(21, 15, 19)]
        public void CreateParcel_UseValidDimensions_NewParcelIsCreated(int length, int width, int height)
        {
            // Arrange
            var expectedLength = length;
            var expectedWidth = width;
            var expectedHeight = height;

            // Act
            var createdParcel = new Parcel(length, width, height);

            // Assert
            Assert.AreEqual(expectedLength, createdParcel.Length);
            Assert.AreEqual(expectedWidth, createdParcel.Width);
            Assert.AreEqual(expectedHeight, createdParcel.Height);
        }

        #endregion

        #region Get Parcel Size
        [Test]
        [TestCase(5, 6, 7, ExpectedResult = ParcelSizeType.Small)]

        [TestCase(5, 20, 7, ExpectedResult = ParcelSizeType.Medium)]
        [TestCase(49, 43, 27, ExpectedResult = ParcelSizeType.Medium)]

        [TestCase(5, 80, 7, ExpectedResult = ParcelSizeType.Large)]
        [TestCase(20, 30, 97, ExpectedResult = ParcelSizeType.Large)]
        [TestCase(50, 70, 97, ExpectedResult = ParcelSizeType.Large)]

        [TestCase(5, 7, 100, ExpectedResult = ParcelSizeType.XL)]
        [TestCase(5, 70, 197, ExpectedResult = ParcelSizeType.XL)]
        [TestCase(50, 70, 200, ExpectedResult = ParcelSizeType.XL)]
        [TestCase(100, 150, 97, ExpectedResult = ParcelSizeType.XL)]
        public ParcelSizeType GetParcelSize_GetCorrectParcelSize_ExpectedParcelSizeType(int length, int width, int height)
        {
            // Arrange

            // Act
            var newParcel = new Parcel(length, width, height);
            return newParcel.ParcelSize;
        }

        #endregion

        #region Get Parcel Cost
        [Test]
        [TestCase(5, 6, 7, ExpectedResult = 3)]

        [TestCase(5, 20, 7, ExpectedResult = 8)]
        [TestCase(49, 43, 27, ExpectedResult = 8)]

        [TestCase(5, 80, 7, ExpectedResult = 15)]
        [TestCase(20, 30, 97, ExpectedResult = 15)]
        [TestCase(50, 70, 97, ExpectedResult = 15)]

        [TestCase(5, 7, 100, ExpectedResult = 25)]
        [TestCase(5, 70, 197, ExpectedResult = 25)]
        [TestCase(50, 70, 200, ExpectedResult = 25)]
        [TestCase(100, 150, 97, ExpectedResult = 25)]
        public int GetParcelCost_GetCorrectParcelCost_ExpectedParcelCost(int length, int width, int height)
        {
            // Arrange

            // Act
            var newParcel = new Parcel(length, width, height);
            return newParcel.ParcelCost;
        }

        #endregion
    }
}
