using System;
using MathsComponentNameSpace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            
            MathsComponent obj = new MathsComponent();
            int result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestSubstract()
        {
            MathsComponent obj = new MathsComponent();
            int result = obj.Substract(10, 1);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestMultiple()
        {

            MathsComponent obj = new MathsComponent();
            int result = obj.Multiple(10, 10);
            Assert.AreEqual(100, result);
        }
        [TestMethod]
        public void TestDivide()
        {

            MathsComponent obj = new MathsComponent();
            int result = obj.Divide(10, 10);
            Assert.AreEqual(1, result);
        }

    }
}
