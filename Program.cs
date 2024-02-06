using System;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int.TryParse(age, out int Age);
            int more = 18 - Age;
            if(Age >= 18)
            {
                Console.WriteLine("You can legally vote in Nepal");
            }
            else
            {
                Console.WriteLine("Sorry buddy! You still have to wait " + more + " more years.");
            }
        }
    }
}