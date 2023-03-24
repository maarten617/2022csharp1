using System;

namespace FunctionOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.AskForAge();


        }
        private void AskForAge()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"You're age is {age}");
        }
    }
}