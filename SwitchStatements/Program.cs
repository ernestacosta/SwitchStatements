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
                case "physics":
                case "chemistry":
                    Console.WriteLine("Science is tough!");
                    break;
                case "english":
                case "grammar":
                    Console.WriteLine("I have English!");
                    break;
                case "pe":
                case "physical education":
                    Console.WriteLine("PE is fun!");
                    break;
                case "history":
                    Console.WriteLine("History is boring!");
                    break;
                default:
                    Console.WriteLine($"Ah I haven't taken that subject before. {subject} sounds exciting!");
                    break;
            }
        }
    }
}
