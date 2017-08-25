using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TextAdventure
{

    {
    public partial class Form1 : Form
    {


        public void WriteText(string text)
    {
        Console.SetCursorPosition(0, Console.CursorTop);
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
            var t = new Write();
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
            t.WriteText(">Adventure Start<");
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
                        t.WriteText("\"Get up, we need to go, now!\"");
                        wrongInput = false; // loop break
                    }
                    else if (choice.Key == ConsoleKey.D2)
                    {
                        t.WriteText(">Three men enter the room and kill you both.");
                        Environment.Exit(0);
                        break; // just incase loop wants to repeat
                    }

                }
            }
            {
                t.WriteText("\"We're under attack, they've found us.\"");
                t.WriteText(">As you wake up you notice the room around you.\n" +
                    ">it's filled with weapons and the walls are horribly damaged.\n" +
                    ">you hear what sounds like gunfire coming from outside.");
                t.WriteText(">You're overwhelmed with pain.");
                t.WriteText("\"Come on, through here.\"");
                t.WriteText(">You notice a pistol sitting next to you.");
                bool wrongInput = true; //set it to true just incase it was false from prev loop
                while (wrongInput) //the loop
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.WriteLine("Do you pick it up or leave it there?");
                    Console.WriteLine("1) Pick it up 2)Leave it there");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ConsoleKeyInfo choice = Console.ReadKey(); // second choice variable because the first one exists in a if loop
                    if (choice.Key == ConsoleKey.D1) // check choice instead of keypress
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        t.WriteText(">You take the pistol and rush to the door.");
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        Console.WriteLine();
                        Console.WriteLine(">As you enter the next room you see three men - all of them armed.");
                        Console.WriteLine();
                        Console.WriteLine("What do you do?  Shoot or don't shoot?");
                        Console.WriteLine("1) Shoot 2) Don't Shoot");
                        choice = Console.ReadKey(); // sets choice to the button pressed (instead of calling choice again)

                        if (choice.Key == ConsoleKey.D1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(0, Console.CursorTop - 1);

                            t.WriteText(">You shot all three of them with the pistol you picked up. You can move on.");


                                {
                            {
                                WindowsMediaPlayer player = new WindowsMediaPlayer();

                                Form1();
                                {
                                    InitializeComponent();
                                    player.URL = "gunshot.wav";
                                }

                                void Form1_Load(object sender, EventArgs e)
                                {
                                    player.controls.play();
                                }
                            }
                            t.WriteText("\"That was a close one back there, " + name + "\"");
                            t.WriteText(">Dmitri pats you on the back and points to the exit from the building.");
                            t.WriteText(">You walk out the door and see an orange sky, the gunfire is louder than before.");
                            t.WriteText("\"Get over here!\"  Take cover from them before they blow you to bits!' - says a man wearing a fur cap.");
                            t.WriteText("\"What are you doing, kid? You could have gotten yourself killed out there.\"");
                            t.WriteText("\"Here, take this.\"\n" +
                                ">The man hands you a box of grenades.");
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            Console.WriteLine();
                            Console.WriteLine("1.) \"What do I do with these?\" 2.) \"Who are you?\" 3.) >Remain silent");
                            Console.WriteLine("(1/2/3)");
                            choice = Console.ReadKey();
                            if (choice.Key == ConsoleKey.D1)
                            {
                                Console.WriteLine();
                                Console.WriteLine("\"What do you think? You throw them at the enemy!\"");
                                Console.WriteLine();
                                wrongInput = false; //loop break
                            }
                            else if (choice.Key == ConsoleKey.D2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("\"I'm me. The real question is: who are you?\"");
                                Console.WriteLine();
                                wrongInput = false; //loop break
                            }
                            else if (choice.Key == ConsoleKey.D3)
                            {
                                Console.WriteLine();
                                Console.WriteLine("\"What are you waiting for? Throw them!\"");
                                Console.WriteLine();
                                wrongInput = false; //loop break
                            }






                        
                        else if (choice.Key == ConsoleKey.D2)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            Console.SetCursorPosition(0, Console.CursorTop - 1);
                            t.WriteText(">Dmitri killed them all. You can move on."); //Todo: Come up with a name for (character) that isn't "Dmitri"
                            wrongInput = false; //loop break
                        }
                    }




                    else if (choice.Key == ConsoleKey.D2)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        t.WriteText(">You leave the pistol and rush to the door, hoping you don't need it.");
                        Console.WriteLine();
                        t.WriteText(">As you enter the next room you see three men - all of them armed.");
                        Console.WriteLine();
                        t.WriteText(">Before you can even move an inch, Dmitri pulls out his rifle and empties a magazine on all of them."); //TODO:shorten this it looks ugly in CMD
                        Console.WriteLine();
                        t.WriteText("\"Why didn't you take the gun I left you?\"");
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
                            t.WriteText("\"It isn't safe to go around unarmed anymore.\"");
                            Console.WriteLine();
                            t.WriteText(">He hands you his pistol.");
                            Console.WriteLine();
                            t.WriteText("\"If you wanna stay alive you're gonna have to use it.\"");
                            wrongInput = false; //loop break
                        }
                        else if (choice.Key == ConsoleKey.D2)
                        {

                            Console.WriteLine();
                            t.WriteText("I'll explain everything soon.");
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