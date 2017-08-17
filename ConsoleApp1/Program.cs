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
            Console.WriteLine();
            Console.WriteLine("Now tell us your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, " + name);
            Console.WriteLine();
            Console.WriteLine(">Adventure start<");
            Console.WriteLine("(Press any key to continue...)");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            {
                bool wrongInput = true;
                while (wrongInput)
                {

                    Console.WriteLine(name + ", wake up! Can you hear me?");

                    Console.WriteLine("1) Yes 2) No");

                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine("Get up, we need to go, now!");


                        Console.WriteLine();
                        wrongInput = false;
                    }

                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(">Three men enter the room and kill you both");
                        Console.WriteLine("(Press any key to quit...)");
                        Console.ReadKey(); // check for button press before exiting
                        Environment.Exit(0);
                        break; // just incase loop wants to repeat
                    }

                }
            }
            {

                Console.WriteLine("We're under attack, they've found us");
                Console.WriteLine("(press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();


                Console.WriteLine(">As you wake up you notice the room around you - it's filled with weapons, the walls are horribly damaged and you hear what sounds like gunfire coming from outside");
                Console.WriteLine("(press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();

                Console.WriteLine(">You're overwhelmed with pain");
                Console.WriteLine("(press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();

                Console.WriteLine("Come on, through here");
                Console.WriteLine("(press any key to continue...)");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.WriteLine(">You notice a pistol sitting next to you");
                Console.WriteLine("(press any key to continue...)");
                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();
                Console.WriteLine("Do you pick it up or leave it there? (1/2)");
                ConsoleKeyInfo choice = Console.ReadKey();
                if (choice.Key == ConsoleKey.D1)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine();
                    Console.WriteLine(">You take the pistol and rush to the door");
                    Console.WriteLine("(Press any key to continue...)");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(">As you enter the next room you see three men - all of them armed");
                    Console.WriteLine();
                    
                    Console.WriteLine("What do you do?  Shoot or don't shoot? (1/2)");
                    choice = Console.ReadKey();
                    if (choice.Key == ConsoleKey.D1)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine(">You shot all three of them with the pistol you picked up. You can move on");
                        Console.WriteLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                    }
                    else if (choice.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine(">Your newfound friend killed them all. You can move on");
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("That was close.. they could have killed us!");
                    Console.WriteLine();

                }
                else if (choice.Key == ConsoleKey.D2)
                {
                    
                    Console.WriteLine(">You leave the pistol and rush to the door, hoping you don't need it");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(">As you enter the next room you see three men - all of them armed");
                    Console.WriteLine();
                    Console.WriteLine(">Before you can even move an inch your newfound friend pulls out his assault rifle and empties a magazine on all of them");
                    Console.WriteLine("Why didn't you take the gun I left you?");
                    Console.WriteLine("1) I thought i wouldn't need it 2)Where are we?");
                    choice = Console.ReadKey();
                    if (choice.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("It isn't safe to go around unarmed anymore");
                        Console.WriteLine(">He hands you his pistol");
                        Console.WriteLine("If you wanna stay alive you're gonna have to use it");
                    }
                    else if (choice.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("I'll explain everything soon");
                    }
                }
                Console.WriteLine("END OF STORY -- Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

