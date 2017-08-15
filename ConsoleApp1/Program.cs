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


                string answer;
                answer = (Console.ReadLine());
                Console.WriteLine("Do you pick it up or leave it there? (1/2)");
                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine(">You take the firearm and rush to the door");
                    Console.WriteLine("(Press enter to continue)");
                    Console.ReadKey();

                    Console.WriteLine(">As you enter the next room you see three men - all of them unfriendly");

                    string answer2 = Console.ReadLine();
                    Console.WriteLine("What do you do?  Shoot or don't shoot? (1/2)");
                    if (Console.ReadKey().Key == ConsoleKey.D1)

                        Console.WriteLine(">You shot all three of them with the weapon you picked up, killing them - you can move on");

                    else if (Console.ReadKey().Key == ConsoleKey.D2)

                        Console.WriteLine(">Your newfound friend shot them all, killing them - you can move on");

                    Console.WriteLine("That was close.. they could have killed us both!");


                }
                else if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    Console.WriteLine(">You leave the firearm and rush to the door, hoping you don't need it");
                }




                Console.ReadLine();
                Console.ReadLine();
                Console.ReadLine();

            }
        }
    }
}

