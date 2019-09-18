using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaineClasse.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;

            if(!string.IsNullOrEmpty(first))
            {
                if(isSupervisor)
                {
                    ret = new Supervisor();
                }
                else
                {
                    ret = new Employee();
                }
                ret.FirstName = first;
                ret.LastName = last;
            }
            return ret;
        }
        // This method simulates retrieving a list of Person objects from this place to collections.....
        public List<Person>GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Janko", LastName = "Petrovic" });
            people.Add(new Person() { FirstName = "Petar", LastName = "Jankovic" });
            people.Add(new Person() { FirstName = "Jim", LastName = "Ruhler" });

            return people;
        }
    }
}
