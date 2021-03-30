using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string name;
            string noiseChoise;
            string doorChoise;
            string riddleAnswer;
            string keyChoise;

            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //Stroy
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from the down the hall.");
            Console.WriteLine();
            Console.WriteLine("Do you investigate? (YES or NO)");
            noiseChoise = Console.ReadLine().ToUpper();
            
            if (noiseChoise == "NO")
            {
                Console.WriteLine("Not much of an adventure if we dont't leave our room!");
                Console.WriteLine("THE END.");
            }
            else if (noiseChoise =="YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door ");
                Console.WriteLine("You walk towards it.");
                Console.WriteLine("Do you open it or knock? (Open or Knock)" );
                doorChoise = Console.ReadLine().ToUpper();

                if (doorChoise =="KNOCK")
                {
                    Console.WriteLine("A voice behind the door speak. Its says, \"Answer this riddle: \"");
                    Console.WriteLine("    Poor people have it.\n    Rich people need.\n    If you eat it you'll die.\nWhat is it?");
                    Console.WriteLine("Type your answer: ");
                    riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING") 
                    {
                        Console.WriteLine("The door opens and NOTHING is there.");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("THE END.");
                    }
                    else
                    {
                        Console.WriteLine("Your answered incorrectly. The door doesn't open");
                        Console.WriteLine("THE END.");
                    }                    
                }
                else if (doorChoise == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("End a number (1-3):");
                    keyChoise = Console.ReadLine();

                    switch (keyChoise)
                    {
                        case ("1"):
                            Console.WriteLine("You choose the first key, Lucky choice! \n The door opens and NOTHING is there. Strange... \n THE END.");
                        break;
                        case ("2"):
                            Console.WriteLine("You choose the second key. The door doesn't open. \n THE END.");
                            break;
                        case ("3"):
                            Console.WriteLine("You choose the third key. The door doesn't open. \n THE END.");
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}