using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch  (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "science":
                    Console.WriteLine("Science is tough!");
                    break;
                case "english":
                    Console.WriteLine("English is boring!");
                    break;
                case "pe":
                    Console.WriteLine("PE is fun!");
                    break;
                default:
                    Console.WriteLine($"Ah I haven't taken that subject before. {subject} sounds exciting!");
                    break;
            }
        }
    }
}
