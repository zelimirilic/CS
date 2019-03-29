using System;

namespace AbstractClassDemo
{
    public class Manager : Employee
    {
        public override void GiveRaise()
        {
            Salary += Salary * 0.1;
        }
    }
}