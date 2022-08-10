using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter Your Favorite Subject");
            Console.WriteLine("Press 1 for Math. \n Press 2 for Science. \n Press 3 for English. \n" +
                "Press 4 for Spanish. \n Press 5 for History.");
            var favSubject = int.Parse(Console.ReadLine());
            switch (favSubject)
            {
                case 1:
                    Console.WriteLine("Math is your favorite subject");
                    break;
                case 2:
                    Console.WriteLine(" Science is your favorite");
                    break;
                case 3:
                    Console.WriteLine("English is your favorite");
                    break;
                case 4:
                    Console.WriteLine("Spanish is your favorite");
                    break;
                case 5:
                    Console.WriteLine("History is your favorite");
                    break;

                default:
                    Console.WriteLine("You dont have a favoite");
                    break;
            }
        }
    }
}
