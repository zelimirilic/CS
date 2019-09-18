using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaineClasse.PersonClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace MaineClasseTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/NotEqual Tests and IsInstanceOfType Test
        [TestMethod]
        [Owner("ZeljkoIlic")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Paulina", "Wozniack", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        [Owner("ZeljkoIlicBgd")]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Wozniack", true);

            Assert.IsNull(per);
        }

        [TestMethod]
        [Owner("Zelko")]
        public void AreEqualTest()
        {
            string str1 = "Paul";
            string str2 = "Paul";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("Zeljko")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Paul";
            string str2 = "paul";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("Zeks")]
        public void AreNotEqualTest()
        {
            string str1 = "Paul";
            string str2 = "Paola";

            Assert.AreNotEqual(str1, str2);
        }

        [TestMethod]
        [Owner("PaulS")]
        public void AreSameTest()
        {
            FileProccesTest x = new FileProccesTest();
            FileProccesTest y = x;

            Assert.AreSame(x, y);

        }

        [TestMethod]
        [Owner("JohnK")]
        public void AreNotSameTest()
        {
            FileProccesTest x = new FileProccesTest();
            FileProccesTest y = new FileProccesTest();

            Assert.AreNotSame(x, y);

        }
        
        #endregion
    }
}
