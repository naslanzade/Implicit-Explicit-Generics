using System;

namespace Implicit_Explicit_Generics
{
    internal class Employee<T>
    {
        private double salary;
        private DateTime birthdaydate;

        public Employee(double salary, DateTime birthdaydate)
        {
            this.salary = salary;
            this.birthdaydate = birthdaydate;
        }
    }
}