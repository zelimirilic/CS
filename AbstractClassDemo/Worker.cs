using System;

namespace AbstractClassDemo
{
    public class Worker : Employee
    {
        public override void GiveRaise()
        {
            Salary += Salary * 0.05;
        }
    }
}