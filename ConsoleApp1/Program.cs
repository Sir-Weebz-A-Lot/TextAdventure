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

            {
                bool wrongInput = true;
                while (wrongInput)
                {
                    Console.WriteLine("Can you hear me?");
                    string answer = Console.ReadLine();
                    if (answer == "Yes")
                    {
                        Console.WriteLine("Good, we can get started.");
                        Console.WriteLine();
                        wrongInput = false;
                    }

                    else if (answer == "No")
                    {
                        Console.WriteLine("Then how did you hear me, to answer?");
                        Console.WriteLine();
                    }

                }
            }
            {
                Console.WriteLine("You've been in a coma for a year, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("Now that you've woke up, we will run you through some tests");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">You're overwhelmed with pain<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You were in a horrible accident, we'll need to test how you walk and such");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">the doctor helps you out of the bed and up to your feet; you feel nauseous and dizzy<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("We've been keeping your muscle mass over the years via therapy, " + name);
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You should be fine after all of this time.  >you stand up and use the bed as a crutch as you try to walk towards the door<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">You suddenly pass out, hitting the floor with your head<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">You wake up in a the hospital bed once again, this time much sooner than before, a nurse is checking up on you and you try to get her attention<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">The nurse went off to get the doctor, five minutes later he arrives<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(">The doctor walks in and looks at you, you sit up in the bed and watch what he's doing<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine("You have sustained major head trauma from the accident I told you about...");
                Console.WriteLine("You barely survived. We had to operate on you for a full week.");
                Console.WriteLine(">You then hear people banging on the door<");
                Console.WriteLine("Oh no! There are people here for your head! >you suddenly feel an overwhelming sense of tiredness; you nod off<");
                Console.WriteLine("(Press enter to continue)");
                Console.ReadLine();

                Console.WriteLine(name + ",can you hear me?  Wake up!");
                Console.WriteLine(">You wake up, not knowing where you are or even who the person who woke you up is");


            }


            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();


        }
    }
}
