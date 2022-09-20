using System.Collections.Generic;

namespace GradeBook
{
   
    class Program
    {   
        static void Main(string[] args)
        {   
            var book = new Book("Sully's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStats();

            
            /*if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello!");
            } */
        }
    }
}