using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalculator;

namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("Add")]
        public void AddSimple()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(1, 2);
            Assert.AreEqual(3, sum);
        }

        [TestMethod]
        [TestCategory("Divide")]
        public void DivideSimple()
        {
            Calculator calculator = new Calculator();
            int quotient = calculator.Divide(10, 5);
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        [TestCategory("Divide")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();
            calculator.Divide(10, 0);
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method1(1, 2, 3);
            Assert.AreEqual(0 , sum);
        }
        [TestMethod]
        [TestCategory("MyTests")]
        public void Test11()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method1(30, 20, 50);
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void Test2()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method2(100, 200);
            Assert.AreEqual(300, sum);
        }
        [TestMethod]
        [TestCategory("MyTests")]
        public void Test22()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method2(5, 5);
            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void Test3()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method3(100, 100);
            Assert.AreEqual(1, sum);
        }
        [TestMethod]
        [TestCategory("MyTests")]
        public void Test33()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method3(40, 8);
            Assert.AreEqual(5, sum);
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void Test4()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method4(4, 3, 2, 1);
            Assert.AreEqual(5, sum);
        }
        [TestMethod]
        [TestCategory("MyTests")]
        public void Test44()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Method4(100, 100, 200, 0);
            Assert.AreEqual(0, sum);
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void Test5()
        {
            Calculator calculator = new Calculator();
            string sum = calculator.Method5("Number is ", 10000);
            Assert.AreEqual("Number is 10000", sum);
        }
        [TestMethod]
        [TestCategory("MyTests")]
        public void Test55()
        {
            Calculator calculator = new Calculator();
            string sum = calculator.Method5("Number is ", 1);
            Assert.AreEqual("Number is 1", sum);
        }
    }
}
