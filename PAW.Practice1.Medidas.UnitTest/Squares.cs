using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PAW.Practice1.Medidas.UnitTest
{
    /// <summary>
    /// Summary description for Squares
    /// </summary>
    [TestClass]
    public class Squares
    {
        public Squares()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void SquarePerimeter_PositiveSides()
        {
            var s1 = 4.66;

            var expectedResult = 18.64;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.SquarePerimeter(s1);
            Assert.AreEqual(factresult, expectedResult);
        }
        [TestMethod]
        public void SquarePerimeter_NegativeZeroSides()
        {
            var s1 = -4;

            var expectedResult = 0.0;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.SquarePerimeter(s1);
            Assert.AreEqual(factresult, expectedResult);
        }

        [TestMethod]
        public void SquareArea_PositiveSides()
        {
            var s1 = 4.66; 

            var expectedResult = 21.7156;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.SquareArea(s1);
            Assert.AreEqual(factresult, expectedResult);
        }
        [TestMethod]
        public void SquareArea_NegativeZeroSides()
        {
            var s1 = -4;

            var expectedResult = 0.0;
            var factresult = 0.0;

            var Service1 = new Practice1.Service1();

            factresult = Service1.SquareArea(s1);
            Assert.AreEqual(factresult, expectedResult);
        }
    }
}
