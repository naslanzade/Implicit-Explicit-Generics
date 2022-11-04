using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics.Models
{
    public  class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double celsius)
        {
            Degree = celsius;
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            Kelvin kelvin = new Kelvin(celsius.Degree - 273.15);
            return kelvin;




        }



    }
}
