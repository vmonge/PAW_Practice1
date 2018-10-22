using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PAW.Practice1;


namespace PAW.Practice1.Medidas.UnitTest
{
    [TestClass]
    public class Triangle
    {
        [TestMethod]
        public void TestMethod1()
        {}
        [TestMethod]
        public void TrianglePerimeter_PositiveSides()
        {
            var s1 = 4; var s2 = 8; var s3 = 15;

            var expectedResult = s1 + s2 + s3;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.TrianglePerimeter(s1, s2, s3);
            Assert.AreEqual(factresult, expectedResult);
        }
        [TestMethod]
        public void TrianglePerimeter_NegativeZeroSides()
        {
            var s1 = 4; var s2 = -8; var s3 = 0;

            var expectedResult = 0.0;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.TrianglePerimeter(s1, s2, s3);
            Assert.AreEqual(factresult, expectedResult);
        }
   

        [TestMethod]
        public void TriangleArea_PositiveSides()
        {
            var s1 = 4; var s2 = 8; var s3 = 15;

            var expectedResult = 38;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.TriangleArea(s1, s2, s3);
            Assert.AreEqual(factresult, expectedResult);
        }
       
        [TestMethod]
        public void TriangleArea_NegativeZeroSides()
        {
            var s1 = 4; var s2 = -8; var s3 = 0;

            var expectedResult = 0.0;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.TriangleArea(s1, s2, s3);
            Assert.AreEqual(factresult, expectedResult);
        }



    }
 }

