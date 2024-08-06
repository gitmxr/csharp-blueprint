using System.Globalization;

namespace EnumerationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>() 
            {
                new Todo { Description = "Task-1",EstimatedHours = 6,Status = Status.notStaeted },
                new Todo { Description = "Task-2",EstimatedHours = 8,Status = Status.Completed },
                new Todo { Description = "Task-3",EstimatedHours = 5,Status = Status.InProgress },
                new Todo { Description = "Task-4",EstimatedHours = 7,Status = Status.Deleted },
                new Todo { Description = "Task-5",EstimatedHours = 6,Status = Status.OnHold },
                new Todo { Description = "Task-6",EstimatedHours = 4,Status = Status.Completed },
                new Todo { Description = "Task-7",EstimatedHours = 8,Status = Status.notStaeted },
                new Todo { Description = "Task-8",EstimatedHours = 5,Status = Status.InProgress },
            };              
            Console.ForegroundColor  = ConsoleColor.Green;

            printAssestment(todos);
            Console.ReadLine();

        }

        private static void  printAssestment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                   case Status.notStaeted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                   case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                   case Status.OnHold: 
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;  
                   case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;  
                   case Status.Deleted:    
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                   default:
                        break;
                }
                Console.WriteLine (todo.Description);
            }
            
        }


        class Todo 
        {
            public  String Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status Status { get; set; }

        }

        enum Status 
        {
        notStaeted,
        InProgress,
        OnHold,
        Completed,
        Deleted

        }
    }
}
