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
            Console.WriteLine("Welcome to (unnamed) text adventure!  We hope you enjoy it");
            Console.WriteLine("Now tell us your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine();
            Console.WriteLine(">Adventure start<");
            Console.WriteLine("(Press enter/space to continue)");
            Console.ReadKey();

            {
                bool wrongInput = true;
                while (wrongInput)
                {
                    Console.WriteLine(name + ", wake up! Can you hear me?");
                    Console.WriteLine("1) Yes 2) No");
                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Get up, we need to go, now!");
                        Console.WriteLine();
                        wrongInput = false;
                    }

                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(">Since you couldn't hear him, you died horribly");
                        Console.WriteLine("(Press any key to quit...)");
                        Console.ReadKey(); // check for button press before exiting
                        Environment.Exit(0);
                        break; // just incase loop wants to repeat
                    }

                }
            }
            {

                Console.WriteLine("We're under attack, they've found us");
                Console.WriteLine("(Press enter to continue...)");

                Console.ReadKey();

                Console.WriteLine(">As you wake up you notice the room around you - it's filled with weapons, the walls are horribly damaged and you hear what sounds like gunfire coming from outside");
                Console.WriteLine("(Press enter to continue...)");

                Console.ReadKey();

                Console.WriteLine(">You're overwhelmed with pain");
                Console.WriteLine("(Press enter to continue...)");

                Console.ReadKey();

                Console.WriteLine("Come on, through here");
                Console.WriteLine("(Press enter to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You see a firearm sitting next to you");
                Console.WriteLine("(Press enter to continue...)");
                Console.ReadKey();

                Console.WriteLine("Do you pick it up or leave it there?");
                Console.WriteLine("(take/leave)");
                string answer;
                answer = Console.ReadLine();

                if (answer == "take")
                {
                    Console.WriteLine(">You take the firearm and rush to the door");
                    Console.WriteLine("(Press enter to continue)");
                    Console.ReadKey();

                    Console.WriteLine(">As you enter the next room you see three men - all of them unfriendly");
                    Console.WriteLine("What do you do? Shoot or don't shoot?");
                    string answer2 = Console.ReadLine();
                                        
                    if (answer2 == "Shoot")
                    {
                        Console.WriteLine();
                        Console.WriteLine(">You shot all three of them with the weapon you picked up, killing them - you can move on");
                    }
                    else if (answer2 == "Don't shoot")
                    {
                        Console.WriteLine();
                        Console.WriteLine(">Your newfound friend shot them all, killing them - you can move on");
                    }
                    Console.WriteLine();
                    Console.WriteLine("That was close.. they could have killed us both!");


                }
                else if (answer == "leave")
                {
                    Console.WriteLine(">You leave the firearm and rush to the door, hoping you don't need it");
                }
                


                Console.WriteLine("");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("You should be fine after all of this time.");
                Console.WriteLine(">you stand up and use the bed as a crutch as you try to walk towards the door");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You suddenly pass out, hitting the floor with your head");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">You wake up in a the hospital bed once again, this time much sooner than before, a nurse is checking up on you and you try to get her attention");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(">The nurse went off to get the doctor, five minutes later he arrives");
                Console.WriteLine("(press any key to continue...)");
                Console.ReadKey();


                Console.WriteLine(">The doctor walks in and looks at you, you sit up in the bed and watch what he's doing");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine("You have sustained major head trauma from the accident I told you about...");
                Console.WriteLine("You barely survived. We had to operate on you for a full week.");
                Console.WriteLine(">You then hear people banging on the door");
                Console.WriteLine("Oh no! There are people here for your head!");
                Console.WriteLine(">you suddenly feel an overwhelming sense of tiredness; you nod off");
                Console.WriteLine("(Press any key to continue...)");
                Console.ReadKey();

                Console.WriteLine(name + ",can you hear me?  Wake up!");
                Console.WriteLine(">You wake up, not knowing where you are or even who the person who woke you up is");

                {
                 
                    {
                        Console.WriteLine("(You have four choices to ask the person:");
                        Console.WriteLine("1.) 'Where are we?' 2.) 'Who are you?' 3.) 'What happened?' 4.) 'I have no questions to ask.'");
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

                Console.WriteLine("We were trapped in here by some... psycho");

                Console.ReadLine();
                Console.ReadLine(); // For room after text for (input)
                Console.ReadLine(); 


            }
        }
    }
}

