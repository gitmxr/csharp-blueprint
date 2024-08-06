namespace CollectionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Model = "Tayota",
                color = "red",
                price = "20-lac"
            };

            Book book = new Book();
            book.Name = "Peere Kamil";
            book.Author = "Umera Ahmed";
            book.ISBN = "00-000-0000";

            Book b2 = new Book();
            b2.Name = "abeHayat";
            b2.Author = "Umera Ahmed";
            b2.ISBN = "00-000-0002";
            //List<Book> list = new List<Book>();
            //list.Add(book.Name);
            //list.Add(book.Author);
            //list.Add(book.ISBN);
            //list.Add(book);
            //list.Add(b2);

            //foreach (Book book1 in list)
            //{
            //    Console.WriteLine(book1.Name);
            //    Console.WriteLine(book1.ISBN);
            //}


            // dictionary

            //Dictionary<string,Book> dic = new Dictionary<string,Book>();
            //dic.Add(b2.ISBN, b2);
            //Console.WriteLine(dic["00-000-0002"].Name);

            //dictionary intitionalizer

            List<Book> list = new List<Book>()
            {
               new Book{Name = "jannat k Pattay",Author = "Nimra Ahmed",ISBN = "001"},
               new Book{Name = "Atashe- Ishq",Author = "Rajpot",ISBN = "002"}
            };
            Console.ReadLine(); 

        }
        class Car
        {
            public string Model { get; set; }
            public string color { get; set; }
            public string price { get; set; }
        }
        class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }

    }
}
