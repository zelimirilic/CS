using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaineClasse.PersonClasses;

namespace MaineClasseTest
{
    /// <summary>
    /// Summary description for PersonManagerTest
    /// </summary>
    [TestClass]
    public class PersonManagerTest
    {

        [TestMethod]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            // TODO: Add test logic here
            PersonManager mgr = new PersonManager();
            Person per;
            per = mgr.CreatePerson("Paul", "Sherif", false);

            Assert.IsInstanceOfType(per, typeof(Employee));
      
        }
    }
}
