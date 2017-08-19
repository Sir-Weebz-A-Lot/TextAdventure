using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Write
    {
        public void WriteText(string text)
        {

            Console.WriteLine(text);
            Console.WriteLine("(Press any key to continue...)");
            Console.WriteLine();
            Console.ReadKey();


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to (unnamed) text adventure!  We hope you enjoy it");
            Console.WriteLine();
            Console.WriteLine("Now tell us your name");
            string name;
            name = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, " + name);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(">Adventure start<");
            Console.WriteLine("(Press any key to continue...)");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.ForegroundColor = ConsoleColor.White;
            {

                bool wrongInput = true;
                while (wrongInput)
                {

                    Console.WriteLine(name + ", \"Wake up! Can you hear me?\""); // you can wrap dialogue in quotations by using \ before the quotes and \ after the dialogue "\"hello\"" like that

                    Console.WriteLine("1) Yes 2) Don't respond");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ConsoleKeyInfo choice = Console.ReadKey(); // don't delete choice variable
                    if (choice.Key == ConsoleKey.D1)
                    {
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine("\"Get up, we need to go, now!\"");


                        Console.WriteLine();
                        wrongInput = false;
                    }

                    else if (choice.Key == ConsoleKey.D2)
                    {

                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine(">Three men enter the room and kill you both.");
                        Console.WriteLine("(Press any key to quit...)");
                        Console.ReadKey(); // check for button press before exiting
                        Environment.Exit(0);
                        break; // just incase loop wants to repeat
                    }

                }
            }
            {

                Console.WriteLine("\"We're under attack, they've found us.\"");
                Console.WriteLine("(Press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();


                Console.WriteLine(">As you wake up you notice the room around you.");
                Console.WriteLine();
                Console.WriteLine(">it's filled with weapons and the walls are horribly damaged.");
                Console.WriteLine();
                Console.WriteLine(">you hear what sounds like gunfire coming from outside."); // avoid long lines in the future
                Console.WriteLine();
                Console.WriteLine("(Press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();

                Console.WriteLine(">You're overwhelmed with pain.");
                Console.WriteLine("(Press any key to continue...)");
                Console.WriteLine();

                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();

                Console.WriteLine("\"Come on, through here.\"");
                Console.WriteLine("(Press any key to continue...)");
                Console.WriteLine();
                Console.ReadKey();
                Console.WriteLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.WriteLine(">You notice a pistol sitting next to you.");
                Console.WriteLine("(Press any key to continue...)");
                Console.WriteLine();
                Console.ReadKey();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine();
                bool wrongInput = true; //set it to true just incase it was false from prev loop
                while (wrongInput) //the loop
                {
                    Console.WriteLine("Do you pick it up or leave it there? (1/2)");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ConsoleKeyInfo choice = Console.ReadKey(); // second choice variable because the first one exists in a if loop
                    if (choice.Key == ConsoleKey.D1) // check choice instead of keypress
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine();
                        Console.WriteLine(">You take the pistol and rush to the door.");
                        Console.WriteLine("(Press any key to continue...)");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(">As you enter the next room you see three men - all of them armed.");
                        Console.WriteLine();

                        Console.WriteLine("What do you do?  Shoot or don't shoot? (1/2)");
                        choice = Console.ReadKey(); // sets choice to the button pressed (instead of calling choice again)

                        if (choice.Key == ConsoleKey.D1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(">You shot all three of them with the pistol you picked up. You can move on.");
                            Console.WriteLine();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);

                            Console.WriteLine();
                            Console.WriteLine("\"That was a close one back there, " + name + "\"");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine(">Dmitri pats you on the back and points to the exit from the building.");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();
                            
                            Console.WriteLine();
                            Console.WriteLine(">You walk out the door and see an orange sky, the gunfire is louder than before.");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine("\"Get over here!\"  Take cover from them before they blow you to bits!' - says a man wearing a fur cap."); //Give suggestions on other, better details to add to this/replace this with
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();

                            Console.WriteLine();
                            Console.WriteLine("\"What are you doing, kid? You could have gotten yourself killed out there.\"");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.WriteLine();
                            Console.WriteLine("\"Here, take this.\"");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine(">The man hands you a box of grenades.");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.WriteLine();
                            wrongInput = false; //loop break


                        }
                        else if (choice.Key == ConsoleKey.D2)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine(">Dmitri killed them all. You can move on."); //Todo: Come up with a name for (character) that isn't "Dmitri"
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            wrongInput = false; //loop break
                        }
                    }




                    else if (choice.Key == ConsoleKey.D2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        
                        Console.WriteLine(">You leave the pistol and rush to the door, hoping you don't need it.");
                        Console.WriteLine("(Press any key to continue...)");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine(">As you enter the next room you see three men - all of them armed.");
                        Console.WriteLine("(Press any key to continue...)");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine(">Before you can even move an inch, Dmitri pulls out his rifle and empties a magazine on all of them."); //TODO:shorten this it looks ugly in CMD
                        Console.WriteLine("(Press any key to continue...)");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine("\"Why didn't you take the gun I left you?\"");
                        Console.WriteLine("(Press any key to continue...)");
                        Console.WriteLine();
                        Console.ReadKey();
                        while (wrongInput)
                        {
                            Console.WriteLine("1) \"I thought I wouldn't need it.\"\n 2) \"Where are we?\"");
                            Console.SetCursorPosition(0, Console.CursorTop - 2);
                                choice = Console.ReadKey();
                                if (choice.Key == ConsoleKey.D1)
                                wrongInput = false;
                            else if (choice.Key == ConsoleKey.D2)
                                wrongInput = false;
                        }

                        if (choice.Key == ConsoleKey.D1)
                        {
                            Console.WriteLine();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine("\"It isn't safe to go around unarmed anymore.\"");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine(">He hands you his pistol.");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            Console.WriteLine();
                            Console.WriteLine("\"If you wanna stay alive you're gonna have to use it.\"");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.WriteLine();
                            Console.ReadKey();
                            wrongInput = false; //loop break
                        }
                        else if (choice.Key == ConsoleKey.D2)
                        {
                            
                            Console.WriteLine();
                            Console.WriteLine("I'll explain everything soon.");
                            Console.WriteLine("(Press any key to continue...)");
                            Console.ReadKey();
                            wrongInput = false; //loop break
                        }
                    }
                }
                
                
                if (Console.ForegroundColor == ConsoleColor.Blue)
                {
                    Console.WriteLine("You finished with Good Karma!");
                }
                else if (Console.ForegroundColor == ConsoleColor.Red)
                {
                    Console.WriteLine("You finished with Bad Karma!");
                }
                else if (Console.ForegroundColor == ConsoleColor.DarkRed)
                {
                    Console.WriteLine("You finished with Very Bad Karma!!");
                        }
                else if (Console.ForegroundColor == ConsoleColor.White)
                {
                    Console.WriteLine("You finished with Neutral Karma.");
                }
                Console.WriteLine();
                Console.WriteLine("Finn -- Press any key to exit..."); // instead of ReadLine spam
                Console.ReadKey();
            }
        }
    }
}

