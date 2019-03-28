using System;

namespace Employee2
{
    class Employee
    {
        public int Age {get; set;}
        public string Name {get; set;}
        public double Salary {get; set;}
        public DateTime StartingDate {get; set;}
        public string PhoneNumber {get; set;}
        public void Bonus(double bonusPercent) => Salary += Salary * bonusPercent;
        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }
        public Employee()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Marko = new Employee()
            {
                Age = 35,
                Name = "Marko Jankovic",
                Salary = 100000,
                StartingDate = new DateTime(2019,1,1),
                PhoneNumber = "063/233-546"
            };
            Console.WriteLine("Marko ima {0} godina, poceo je da radi {1} i zaradjuje {2} dinara mesecno.", Marko.Age, Marko.StartingDate, Marko.Salary);
            Marko.Bonus(0.2);
            Console.WriteLine("Marko ima {0} godina, poceo je da radi {1} i zaradjuje {2} dinara mesecno.", Marko.Age, Marko.StartingDate, Marko.Salary);
            Employee Marica = new Employee(29, "Marija Mitrovic", 77000, new DateTime(2010,2,5), "062/555-454");
            Console.WriteLine("\n\nMarija ima {0} godina, pocela je da radi {1} i zaradjuje {2} dinara mesecno.", Marica.Age, Marica.StartingDate, Marica.Salary);
        }
    }
}
