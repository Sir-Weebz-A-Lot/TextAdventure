using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.WriteLine("How are you today?");
            string answer = Console.ReadLine();
            {
                if (answer == "Good")
                    Console.WriteLine("I don't care.");

                else if (answer == "Bad")
                    Console.WriteLine("I don't care.");

                else
                    Console.ReadLine();
            }
               {
                Console.WriteLine("You've been in a coma for nine years, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("Now that you've woke up, we will run you through some... tests");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("*You feel a slight tingle in your left arm as the doctor speaks*");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("*The doctor shouts at you the following* 'WHY ARE WE STILL HERE?!  JUST TO SUFFER!'");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("Every night...  I can feel my arm... and my leg... the comrades we've lost...");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You feel it too, don't you, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("Y/N");
                Console.ReadLine();

                if (answer == "Y")
                    Console.WriteLine("...");

                else if (answer == "N")
                    Console.WriteLine("...");
               }

            
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
