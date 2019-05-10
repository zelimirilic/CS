using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void StringComparisons()
        {
            string Name1 = "prvoIme";
            string Name2 = "prvoIme";

            bool result = String.Equals(Name1, Name2, StringComparison.InvariantCultureIgnoreCase);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IntVariableHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);

        }

        


    }
}
