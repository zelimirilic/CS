using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace MaineClasseTest
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        [Owner("Zelimir")]
        public void ContainsTest()
        {
            string str1 = "John Smith";
            string str2 = "mith";

            StringAssert.Contains(str1, str2);
        }
        [TestMethod]
        [Owner("Zelimir")]
        public void StartWithTest()
        {
            string str1 = "John Smith";
            string str2 = "Joh";

            StringAssert.StartsWith(str1, str2);
        }
        [TestMethod]
        [Owner("Regularija")]
        public void IsAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("all LOWER case He wrote...", r);
        }
        [TestMethod]
        [Owner("Regularija")]
        public void IsNotAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("all LOWER case He wrote...", r);
        }
    }
}
