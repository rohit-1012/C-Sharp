using System.ComponentModel;

namespace fundamentalsEnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Todo> todos = new List<Todo>() { 
                new Todo {Description = "Task 1", EstimatedHours = 6, Status = Status.Completed },
                new Todo {Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress },
                new Todo {Description = "Task 3", EstimatedHours = 4, Status = Status.NotStarted },
                new Todo {Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted },
                new Todo {Description = "Task 5", EstimatedHours = 8, Status = Status.InProgress },
                new Todo {Description = "Task 6", EstimatedHours = 6, Status = Status.OnHold },
                new Todo {Description = "Task 7", EstimatedHours = 8, Status = Status.Deleted },
                new Todo {Description = "Task 8", EstimatedHours = 10, Status = Status.NotStarted },
                new Todo {Description = "Task 9", EstimatedHours = 2, Status = Status.InProgress },
                new Todo {Description = "Task 10", EstimatedHours = 4, Status = Status.InProgress },
                new Todo {Description = "Task 11", EstimatedHours = 3, Status = Status.OnHold },
                new Todo {Description = "Task 12", EstimatedHours = 7, Status = Status.Deleted },
                new Todo {Description = "Task 13", EstimatedHours = 8, Status = Status.Completed },
                new Todo {Description = "Task 14", EstimatedHours = 11, Status = Status.NotStarted }
            };

            printAssessment(todos);

            Console.ReadKey();
        }

        private static void printAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;

                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;

                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }

    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        Completed,
        NotStarted,
        InProgress,
        OnHold,
        Deleted
    }

}