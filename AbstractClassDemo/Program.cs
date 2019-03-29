using System;
using System.Collections.Generic;

namespace AbstractClassDemo
{
    public abstract class Employee
    {
        public string Name {get; set;}
        public double Salary {get; set;}
        private DateTime HireDate;

        public virtual void Hire()
        {
            HireDate = DateTime.Now;
        }
        public abstract void GiveRaise();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Worker();
            emp1.Name = "David";
            emp1.Salary = 50000;
            var emp2 = new Worker();
            emp2.Name = "Saly";
            emp2.Salary = 77000;
            var emp3 = new Manager();
            emp3.Name = "Jim";
            emp3.Salary = 100000;
            var emp4 = new Manager();
            emp4.Name = "Beam";
            emp4.Salary = 150200;

            var employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            foreach(Employee emp in employees)
            {
                Console.WriteLine("{0} plata je {1}", emp.Name, emp.Salary);
                emp.GiveRaise();
                Console.WriteLine(" but now is {0} !!!", emp.Salary);
            }

        }
    }
}
