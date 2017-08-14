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
            Console.WriteLine("What's your Name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.WriteLine("How are you today?");
            string answer = Console.ReadLine();
            {
                if (answer == "Good")
                    Console.WriteLine("That's nice.");

                else if (answer == "Bad")
                    Console.WriteLine("That's too bad.");

                else
                    Console.ReadLine();
            }
               {
                Console.WriteLine("You've been in a coma for nine years, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("Now that you've woke up, we will run you through some tests");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("*You feel a slight tingle in your left arm as the doctor speaks*");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You were in a horrible accident.  We'll need to test how you walk and such.");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("*the doctor helps you out of the bed and up to your feet; you feel nauseous and dizzy*");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("We've been keeping your muscle mass over the years via therapy, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You should be fine after all of this time.  *you stand up and use the bed as a crutch as you try to walk towards the door*");
                Console.ReadLine();

                Console.WriteLine(".....");
                Console.ReadLine();

               }

            
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
