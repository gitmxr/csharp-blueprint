namespace AdditionOfTwoComplexNumbersByOperatorOverlaoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Complex a = new Complex(3,5);
            a.Display();
            Complex b = new Complex(7,2);
            b.Display();
            Complex c = Complex.Add(a, b);
            c.Display();
        }

        class Complex
        {
            private int real;
            private int img;
            public Complex(int r=0, int i=0)
            {
                real = r;   
                img = i;    
            }

            public static Complex Add(Complex a, Complex b)
            {
                Complex temp = new Complex();
                temp.real = a.real + b.real;
                temp.img = a.img + b.img;
                return temp;

            }
            public  void Display()
            {
                Console.WriteLine($"{real} + i{img}");
            }

        }
    }
}
