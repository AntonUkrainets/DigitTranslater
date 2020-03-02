using DigitTranslater;
using DigitTranslater.Localization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DigitTranslaterTests
{
    [TestClass]
    public class ConverterRuTests
    {
        #region Private Members
        private Converter _converter;
        private LanguageNumbersDescriptor _localization;
        #endregion

        public ConverterRuTests()
        {
            _converter = new Converter();
            _localization = new RuLocalizationNumbers();
        }

        [TestMethod]
        public void ConvertNumber0()
        {
            // Arrange
            var descriptor = new NumberDescriptor(0);
            var expectedValue = "ноль";

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
            var expectedValue = "одиннадцать";

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
            var expectedValue = "триста сорок пять";

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
            var expectedValue = "девятьсот девяносто девять";

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
            var expectedValue = "сорок пять тысяч двести пятьдесят шесть";

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
            var expectedValue = "девяносто тысяч";

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
            var expectedValue = "девяносто девять тысяч девятьсот девяносто девять";

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
            var expectedValue = "сто тысяч";

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
            var expectedValue = "девятьсот тысяч";

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
            var expectedValue = "девятьсот девяносто тысяч девятьсот девяносто девять";

            // Act
            var result = _converter.ConvertToString(descriptor, _localization);

            // Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}