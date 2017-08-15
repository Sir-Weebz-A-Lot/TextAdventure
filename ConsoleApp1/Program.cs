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
            Console.WriteLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine();

            {
                bool wrongInput = true;
                while (wrongInput)
                {
                    Console.WriteLine("Can you hear me?");
                    Console.WriteLine("1) Yes 2) No");
                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good, we can get started.");
                        Console.WriteLine();
                        wrongInput = false;
                    }

                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(">You slept another 7 years<");
                        Console.WriteLine("(Press enter to quit)");
                        Console.ReadKey(); // check for button press before exiting
                        Environment.Exit(0);
                        break; // just incase loop wants to repeat
                    }

                }
            }
            {

                Console.WriteLine("You've been in a coma for a year, " + name);
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("Now that you've woke up, we will run you through some tests");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You're overwhelmed with pain<");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("You were in a horrible accident, we'll need to test how you walk and such");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">the doctor helps you out of the bed and up to your feet; you feel nauseous and dizzy<");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("We've been keeping your muscle mass over the years via therapy, " + name);
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("You should be fine after all of this time.  >you stand up and use the bed as a crutch as you try to walk towards the door<");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You suddenly pass out, hitting the floor with your head<");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You wake up in a the hospital bed once again, this time much sooner than before, a nurse is checking up on you and you try to get her attention<");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">The nurse went off to get the doctor, five minutes later he arrives<");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();


                Console.WriteLine(">The doctor walks in and looks at you, you sit up in the bed and watch what he's doing<");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("You have sustained major head trauma from the accident I told you about...");
                Console.WriteLine("You barely survived. We had to operate on you for a full week.");
                Console.WriteLine(">You then hear people banging on the door<");
                Console.WriteLine("Oh no! There are people here for your head! >you suddenly feel an overwhelming sense of tiredness; you nod off<");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(name + ",can you hear me?  Wake up!");
                Console.WriteLine(">You wake up, not knowing where you are or even who the person who woke you up is");

                {
                 
                    {
                        Console.WriteLine("(You have four choices to ask the person: 1.) 'Where are we?' 2.) 'Who are you?' 3.) 'What happened?' 4.) 'I have no questions to ask.'");
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("We're... trapped inside of a slaughterhouse..");
                            Console.WriteLine();
                            
                        }

                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("I don't think that's important right now");
                            Console.WriteLine();
                            
                        }

                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("I'm not sure...");
                            Console.WriteLine();
                            
                        }

                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("...");
                            Console.WriteLine();
                           
                        }

                        else
                            Console.WriteLine("...");
                        
                    }
                    Console.WriteLine("Press any button to exit...");
                    Console.ReadKey(); // checks for button press
                }

            }
        }
    }
}

