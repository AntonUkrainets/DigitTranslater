using DigitTranslater;
using DigitTranslater.Localization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DigitTranslaterTests
{
    [TestClass]
    public class ConverterUaTests
    {
        #region Private Members
        private Converter _converter;
        private LanguageNumbersDescriptor _localization;
        #endregion

        public ConverterUaTests()
        {
            _converter = new Converter();
            _localization = new UaLocalizationNumbers();
        }

        [TestMethod]
        public void ConvertNumber0()
        {
            // Arrange
            var descriptor = new NumberDescriptor(0);
            var expectedValue = "нуль";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber1()
        {
            // Arrange
            var descriptor = new NumberDescriptor(1);
            var expectedValue = "один";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [ExpectedException(
            typeof(FormatException),
            "Input string was not in a correct format"
        )]
        public void ConvertNumberMinus1()
        {
            // Arrange
            var descriptor = new NumberDescriptor(-1);
        }

        [TestMethod]
        public void ConvertNumber11()
        {
            // Arrange
            var descriptor = new NumberDescriptor(11);
            var expectedValue = "одинадцять";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber100()
        {
            // Arrange
            var descriptor = new NumberDescriptor(100);
            var expectedValue = "сто";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber345()
        {
            // Arrange
            var descriptor = new NumberDescriptor(345);
            var expectedValue = "триста сорок п'ять";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber999()
        {
            // Arrange
            var descriptor = new NumberDescriptor(999);
            var expectedValue = "дев'ятсот дев'яносто дев'ять";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber45256()
        {
            // Arrange
            var descriptor = new NumberDescriptor(45256);
            var expectedValue = "сорок п'ять тисяч двісті п'ятдесят шість";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber90000()
        {
            // Arrange
            var descriptor = new NumberDescriptor(90000);
            var expectedValue = "дев'яносто тисяч";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber99999()
        {
            // Arrange
            var descriptor = new NumberDescriptor(99999);
            var expectedValue = "дев'яносто дев'ять тисяч дев'ятсот дев'яносто дев'ять";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber100000()
        {
            // Arrange
            var descriptor = new NumberDescriptor(100000);
            var expectedValue = "сто тисяч";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber900000()
        {
            // Arrange
            var descriptor = new NumberDescriptor(900000);
            var expectedValue = "дев'ятсот тисяч";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}