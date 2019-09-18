using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaineClasse.PersonClasses;
namespace MaineClasseTest
{
    [TestClass]
    public class CollectionsAssertClassTest
    {
        [TestMethod]
        [Owner("Johnjik")]
        public void AreCollectionsEquivalentTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            //Get Person objects
            peopleActual = mgr.GetPeople();

            // Add same Person objects to new collection, but in a different order
            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            //Checks for same objects, but in any order
            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        [Owner("Konjurak")]
        public void AreCollectionsEqualWithComparerTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Janko", LastName = "Petrovic" });
            peopleExpected.Add(new Person() { FirstName = "Petar", LastName = "Jankovic" });
            peopleExpected.Add(new Person() { FirstName = "Jim", LastName = "Ruhler" });

            peopleActual = mgr.GetPeople();
            //provide your "Comparer' to determine equality
            CollectionAssert.AreEqual(peopleExpected, peopleActual, Comparer<Person>.Create((x, y) => x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }
        [TestMethod]
        [Owner("Sultan Murat")]
        public void IsCollectionOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
