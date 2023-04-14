using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        // Main is a method and is equivalent to index.html as in it's the entry point for C#
        static void Main(string[] args)
            
        {
            int number = 64;
            Console.WriteLine("Hello World! {0} is a number or whatever",number);
            // make sure to add static in front of void to avoid creating a new program
            AskUser();
        }
        // void is how you let csharp know that a return is not required, unlike JS C# is strict about that
        // you can add int if you want a number returned instead of void
        static void AskUser()
        {
            // whew this is different but this is essentially like a JS prompt

            Console.WriteLine("What is your favorite number");
            string input = Console.ReadLine();

            // converting input into an integer/ number 
            try {
                int favNumber = Convert.ToInt32(input);
            }
            catch(FormatException)
            {
                Console.WriteLine("Aint a number dum dum");
            }
        }
    }
}