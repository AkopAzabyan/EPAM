﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TriangleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTriangleEquilateralTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(1, 1, 1));
        }

        [TestMethod]
        public void IsTriangleRightTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 8, 10));
        }

        [TestMethod]
        public void IsTriangleIsoscelesTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(2, 2, 3));
        }

        [TestMethod]
        public void IsTriangleAllSidesNullTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(0, 0, 0));
        }

        [TestMethod]
        public void IsIsoscelesTriangleBadTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(1, 4, 7));
        }

        [TestMethod]
        public void IsTriangleGoodTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(4, 5, 6));
        }

        [TestMethod]
        public void IsIsoscelesTriangleOneBadSideTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(4, -5, 6));
        }

        [TestMethod]
        public void IsTriangleTwoBadSidesTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(-4, -5, 6));
        }

        [TestMethod]
        public void IsRightTriangleThreeBadSidesTest()
        {
            Assert.IsFalse(Triangle.IsTriangle(-4, -5, -6));
        }

        [TestMethod]
        public void IsTriangleDoubleGoodTest()
        {
            Assert.IsTrue(Triangle.IsTriangle(2.5, 3.5, 4.5));
        }
    }
}
