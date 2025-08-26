using System;

namespace MethodOverloadingAndOverriding
{
    class Program 
    {static void Main(string[] args)
        {
            MathOps mathOps = new MathOps();
            Console.WriteLine("Product is: "+ mathOps.Multiply(6, 3));
            Console.WriteLine("Product is: "+ mathOps.Multiply(6.2, 5.0));
            Console.WriteLine("Product is: "+ mathOps.Multiply(1.5, 1.5, 5.2));
            Console.WriteLine("#####################################");
            
            // upcasting for polymorphism
            Shape s1 = new Circle();
            Shape s2 = new Square();
            s1.Draw();
            s2.Draw();
        }
    
    }

    class MathOps
    {
        public int Multiply(int x, int y) =>  x * y;
        public double Multiply(double x, double y) => x * y;
        public double Multiply(double x, double y, double z) => x * y * z;

        //public int Multiply(int x, int y)
        //{
        //   return x * y;
        //}
        //public double Multiply(double x, double y)
        //{
        //    return x * y;
        //}
        //public double Multiply(double x, double y, double z)
        //{
        //    return x * y * z;
        //}
    }
    class Shape
    {
        public virtual void Draw()
        {
        }
    }
    class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
    class Square:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }
    

} 