using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics.Models
{
    public class Employee1<T>
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        
        private DateTime _BirthdayDate;      
                
        public DateTime BirthdayDate
        {
            get { return _BirthdayDate; }
            set { _BirthdayDate = value; }
        }

        private DateTime _FirstDate;

        public DateTime firstdate
        {
            get { return _FirstDate; }
            set { _FirstDate = value; }
        }


        private DateTime _SecondDate;

        public DateTime seconddate
        {
            get { return _SecondDate; }
            set { _SecondDate = value; }
        }


        private T[] _data;
        private static int count;
        

        public Employee1(DateTime BirthdayDate)
        {
            this.BirthdayDate = BirthdayDate;

        }
        public DateTime Birthdaydate()
        {
            return BirthdayDate;
        }


                
        public void GetCountOfEmployee()
        {

            Birthdaydate();

            firstdate = new DateTime(2004, 12, 31);

            seconddate = new DateTime(1987, 12, 31);
                        
            if (Birthdaydate() > firstdate && Birthdaydate() < seconddate && Salary > 2000)
            {
                for (int i = 0; i < _data.Length; i++)
                {
                    count++;
                }
                Console.WriteLine(count);
            }

        }


        public Employee1(T data)
        {
            _data = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _data, _data.Length + 1);

            _data[_data.Length - 1] = data;
        }




    }
}

