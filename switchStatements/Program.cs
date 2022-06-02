using System;

namespace switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Nice choice! Math can be tough.");
                    break;
                case "science":
                    Console.WriteLine("Science can be tricky.");
                    break;
                case "english":
                    Console.WriteLine("Nice! English can be difficult.");
                    break;
                case "history":
                    Console.WriteLine("History teachers make the best storytellers.");
                    break;
                case "gym":
                    Console.WriteLine("Gym can be a fun way to get out energy.");
                    break;
                default:
                    Console.WriteLine("I didn't think of that one. Kudos!");
                    break;
            }
        }
    }
}

