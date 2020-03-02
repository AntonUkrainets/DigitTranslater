using DigitTranslater;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigitTranslaterTests
{
    [TestClass]
    public class NumberDesriptorTests
    {
        [TestMethod]
        public void TestUnits_1()
        {
            // Arrange
            var value = 1;
            var expectedUnit = 1;
            var expectedDozens = 0;
            var expectedHunderds = 0;

            // Act
            var numberDesriptor = new NumberDescriptor(value);

            // Assert
            Assert.AreEqual(expectedUnit, numberDesriptor.Units);
            Assert.AreEqual(expectedDozens, numberDesriptor.Dozens);
            Assert.AreEqual(expectedHunderds, numberDesriptor.Hundreds);
        }

        [TestMethod]
        public void TestDozens_10()
        {
            // Arrange
            var value = 10;
            var expectedUnit = 0;
            var expectedDozens = 1;
            var expectedHunderds = 0;

            // Act
            var numberDesriptor = new NumberDescriptor(value);

            // Assert
            Assert.AreEqual(expectedUnit, numberDesriptor.Units);
            Assert.AreEqual(expectedDozens, numberDesriptor.Dozens);
            Assert.AreEqual(expectedHunderds, numberDesriptor.Hundreds);
        }

        [TestMethod]
        public void TestDozens_11()
        {
            // Arrange
            var value = 11;
            var expectedUnit = 1;
            var expectedDozens = 1;
            var expectedHunderds = 0;

            // Act
            var numberDesriptor = new NumberDescriptor(value);

            // Assert
            Assert.AreEqual(expectedUnit, numberDesriptor.Units);
            Assert.AreEqual(expectedDozens, numberDesriptor.Dozens);
            Assert.AreEqual(expectedHunderds, numberDesriptor.Hundreds);
        }

        [TestMethod]
        public void TestNumber_345()
        {
            // Arrange
            var value = 345;
            var expectedUnit = 5;
            var expectedDozens = 4;
            var expectedHunderds = 3;

            // Act
            var numberDesriptor = new NumberDescriptor(value);

            // Assert
            Assert.AreEqual(expectedUnit, numberDesriptor.Units);
            Assert.AreEqual(expectedDozens, numberDesriptor.Dozens);
            Assert.AreEqual(expectedHunderds, numberDesriptor.Hundreds);
        }

        [TestMethod]
        public void TestNumber_999()
        {
            // Arrange
            var value = 999;
            var expectedUnit = 9;
            var expectedDozens = 9;
            var expectedHunderds = 9;

            // Act
            var numberDesriptor = new NumberDescriptor(value);

            // Assert
            Assert.AreEqual(expectedUnit, numberDesriptor.Units);
            Assert.AreEqual(expectedDozens, numberDesriptor.Dozens);
            Assert.AreEqual(expectedHunderds, numberDesriptor.Hundreds);
        }
    }
}