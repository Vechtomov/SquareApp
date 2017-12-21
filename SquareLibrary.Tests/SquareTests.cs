using SquareLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareLibrary.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void GetSquareOfRightTriangle_345_6returned()
        {
            double expected = 6;

            double result = Square.GetSquareOfRightTriangle(3, 4, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSquareOfRightTriangle_453_6returned()
        {
            double expected = 6;

            double result = Square.GetSquareOfRightTriangle(4, 5, 3);

            Assert.AreEqual(expected, result);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException), "Exception was not thrown")]
        [TestMethod]
        public void GetSquareOfRightTriangle_045_ExpectedException()
        {
            double result = Square.GetSquareOfRightTriangle(0, 4, 5);
        }

        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void GetSquareOfRightTriangle_123_ExpectedException()
        {
            double result = Square.GetSquareOfRightTriangle(1, 2, 3);
        }

        [ExpectedException(typeof(ArgumentException), "Exception was not thrown")]
        [TestMethod]
        public void GetSquareOfRightTriangle_133_ExpectedException()
        {
            double result = Square.GetSquareOfRightTriangle(1, 3, 3);
        }
    }
}
