using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please write a phrase:");
            string phrase = Console.ReadLine();
            Console.WriteLine("Please insert a character:");
            char character = char.Parse(Console.ReadLine());

            string modified = phrase.Replace(character, 'x');
            Console.WriteLine(modified);


        }
    }
}
