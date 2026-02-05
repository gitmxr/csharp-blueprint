using System;

namespace Operator_Oveloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(4, 5);
            ComplexNumber b = new ComplexNumber(2, 3);

            ComplexNumber sum = a + b;
            Console.WriteLine("sum: "+sum);

            ComplexNumber diff = a - b;
            Console.WriteLine("diff: "+diff);
            Console.ReadLine();

        }
        public class ComplexNumber
        {
            public double Real {  get; set; }
            public double Imaginary { get; set; }

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            {
               return new ComplexNumber( a.Real + b.Real, a.Imaginary + b.Imaginary);
            }

            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            {
               return new ComplexNumber( a.Real - b.Real, a.Imaginary - b.Imaginary);
            }


            public override string ToString()
            {
                return $"{Real} + {Imaginary}i";
            }

        }
    }
}
