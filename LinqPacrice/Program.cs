namespace LinqPacrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCar = new List<Car>()
            {
                new Car{Make = "Tayota",Price = 25000,Color ="white",Year = "1990"},
                new Car{Make = "BMW",Price = 5500,Color ="Black",Year = "2015"},
                new Car{Make = "BMW",Price = 6000,Color ="White",Year = "2020"},
                new Car{Make = "BMW",Price = 8500,Color ="Golden",Year = "2022"},
                new Car{Make = "BMW",Price = 9000,Color ="Black",Year = "2023"},
                new Car{Make = "Hyndai",Price = 35000,Color ="Red",Year = "2017"},
                new Car{Make = "marcedes",Price = 45000,Color ="Grey",Year = "2000"},
            };


            //Linq

            //linq Query  
            //var BMW = from car in myCar
            //         where car.Make == "BMW"
            //         select car;


            //var BMW = from car in myCar
            //          orderby car.Year descending
            //          select car;




            //Linq Method

            //var BMW = myCar.Where(x => x.Make == "BMW");

            //var BMW = myCar.OrderByDescending(x => x.Year);


            // var firstCar = myCar.First();

            //var firstBMW = myCar.First(x => x.Make == "BMW");
            // Console.WriteLine(firstBMW.Year);

            //foreach (var car in BMW)
            //{
            //    Console.WriteLine("Color: {0}, Year: {1}, Price: {2:C} "
            //                      , car.Color, car.Year, car.Price);
            //}

            //Console.WriteLine( myCar.Exists(p => p.Make == "Tayota"));

            //Console.WriteLine( myCar.Sum(p => p.Price));

            Console.WriteLine(myCar.GetType());

            //var BMW = myCar.OrderByDescending(x => x.Year);
            //Console.WriteLine(BMW.GetType());

            Console.ReadLine();
        }
        class Car
        {
            public string Make { get; set; }
            public int Price { get; set; }
            public string Color { get; set; }
            public string Year { get; set; }
        }
        }
    }
