using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Model = "BMW";
            myCar.year = 2016;
            myCar.color = "Black";

            Console.WriteLine("Model : {0}\n Year : {1}\n Color : {2} ",
                myCar.Model,
                myCar.year,
                myCar.color);
        }
    }
    class Car
    {
        public string Model { get; set; }
        public string color { get; set; }
        public int year { get; set; }    
    }
}
