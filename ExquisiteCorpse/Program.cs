using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String monsterChoice;
            Console.WriteLine("\nHow would you like to build your creature?\nRandom or Self:");
            monsterChoice = Console.ReadLine().ToUpper();
            if (monsterChoice == "SELF")
            {
                BuildMode();
            }
            else if (monsterChoice =="RANDOM")
            {
                RandomMode();
            }
            else
            {
                Console.WriteLine("Good-bye!");
            }
        }
        static void BuildMode()
        {
            //Variables
            string head;
            string body;
            string feet;

            Console.WriteLine("\nWhat head would you like for your creature?\nGhost\nMonster\nBug");
            head = Console.ReadLine().ToUpper();

            Console.WriteLine("\nWhat body would you like for your creature?\nGhost\nMonster\nBug");
            body = Console.ReadLine().ToUpper();

            Console.WriteLine("\nWhat feet would you like for your creature?\nGhost\nMonster\nBug");
            feet = Console.ReadLine().ToUpper();

            BuildACeature(head, body, feet);
        }
        static void RandomMode()
        {
            int head;
            int body;
            int feet;

            Random randomNumber = new Random();

            head = randomNumber.Next(1, 4);
            body = randomNumber.Next(1, 4);
            feet = randomNumber.Next(1, 4);

            SwitchCase(head,body,feet);
        }
        static void SwitchCase(int head, int body, int feet)
        {
            string stringHead = BodyIntToString(head);
            string stringBody = BodyIntToString(body);
            string stringFeet = BodyIntToString(feet);

            BuildACeature(stringHead,stringBody,stringFeet);
        }
        static string BodyIntToString(int bodyPart)
        {
            switch (bodyPart)
            {
                case (1):
                    return "GHOST";
                case (2):
                    return "MONSTER";
                case (3):
                    return "BUG";
                default:
                    return "Ghost";
                    
            }

        }
        static void BuildACeature(string head, string body, string feet)
        {

            switch (head)
            {
                case ("GHOST"):
                    GhostHead();
                    break;

                case ("MONSTER"):
                    MonsterHead();
                    break;

                case ("BUG"):
                    BugHead();
                    break;

                default:
                    break;
            }
            switch (body)
            {
                case ("GHOST"):
                    GhostBody();
                    break;

                case ("MONSTER"):
                    MonsterBody();
                    break;

                case ("BUG"):
                    BugBody();
                    break;

                default:
                    break;
            }
            switch (feet)
            {
                case ("GHOST"):
                    GhostFeet();
                    break;

                case ("MONSTER"):
                    MonsterFeet();
                    break;

                case ("BUG"):
                    BugFeet();
                    break;

                default:
                    break;
            }
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }
        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }
        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }
        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }
        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }
        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }
        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }
        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }
        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
