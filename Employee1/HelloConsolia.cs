using System;

namespace Classes {
    class Employee {
        private int age;
        public int Age {
            get { return age; }
            set { age = value; }
        }
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Nadimak {get; set;}
        public string Firma {get; set;}
    }
    class Program {
        static void Main (string[] args) {
            Employee Darko = new Employee ();
            Employee Ivan = new Employee ();
            Employee Milos = new Employee();
            Employee Vuk = new Employee();
            Darko.Age = 44;
            Darko.Name = "Darko";
            Darko.Nadimak = "Dare";
            Darko.Firma = "Hotel Promaja";
            Ivan.Age = 35;
            Ivan.Name = "Ivan";
            Ivan.Nadimak = "Ivanjesku";
            Ivan.Firma = "Bravo";
            Milos.Age = 28;
            Milos.Name = "Milos";
            Milos.Nadimak = "LosMi";
            Milos.Firma = "BW";
            Vuk.Name = "Vuk";
            Vuk.Age = 18;
            Vuk.Firma = "Coca-Cola";
            Vuk.Nadimak = "Wolf";
            Console.WriteLine ("{1} ima {0} godina i zovu ga {2} a radi u {3}.", Darko.Age, Darko.Name, Darko.Nadimak, Darko.Firma);
            Console.WriteLine ("{1} ima {0} godina i zovu ga {2} a radi u {3}.", Ivan.Age, Ivan.Name, Ivan.Nadimak, Ivan.Firma);
            Console.WriteLine ("{1} ima {0} godina i zovu ga {2} a radi u {3}.", Milos.Age, Milos.Name, Milos.Nadimak, Milos.Firma);
            Console.WriteLine ("{1} ima {0} godina i zovu ga {2} a radi u {3}.", Vuk.Age, Vuk.Name, Vuk.Nadimak, Vuk.Firma);
        }

    }

}