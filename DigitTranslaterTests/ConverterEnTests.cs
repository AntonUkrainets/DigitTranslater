using DigitTranslater;
using DigitTranslater.Localization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DigitTranslaterTests
{
    [TestClass]
    public class ConverterEnTests
    {
        #region Private Members
        private Converter _converter;
        private LanguageNumbersDescriptor _localization;
        #endregion

        public ConverterEnTests()
        {
            _converter = new Converter();
            _localization = new EnLoсalizationNumbers();
        }

        [TestMethod]
        public void ConvertNumber0()
        {
            // Arrange
            var descriptor = new NumberDescriptor(0);
            var expectedValue = "zero";

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
            var expectedValue = "one";

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
            var expectedValue = "eleven";

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
            var expectedValue = "one hundred";

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
            var expectedValue = "three hundred forty five";

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
            var expectedValue = "nine hundred ninety nine";

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
            var expectedValue = "forty five thousand two hundred fifty six";

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
            var expectedValue = "ninety thousand";

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
            var expectedValue = "ninety nine thousand nine hundred ninety nine";

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
            var expectedValue = "one hundred thousand";

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
            var expectedValue = "nine hundred thousand";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ConvertNumber999999()
        {
            // Arrange
            var descriptor = new NumberDescriptor(999999);
            //nine hundred thousand ninety nine thousand nine hundred ninety nine
            var expectedValue = "nine hundred ninety nine thousand nine hundred ninety nine";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}