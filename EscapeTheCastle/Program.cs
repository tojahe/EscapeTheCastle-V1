using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheCastle
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // = = = = = = = = = =  L E V E L - 1 = = = = = = = = = =




            // = = = = = = = = = =  V A R I A B L E S = = = = = = = = = = 


            string ynAgree = "Y";
            string userYNagree = "";

            string ynDisagree = "N";
            string userYNdisagree = "";

            // = = = = = = = = = =  R I D D L E S = = = = = = = = = =  

            string riddle1 = "What gets wet when drying?";
            string riddle1CorrectAnswer = "a towel";
            string riddle1UserAnswer = "";

            string riddle2 = "What gets bigger the more you take away?";
            string riddle2CorrectAnswer = "a hole";
            string riddle2UserAnswer = "";

            string riddle3 = "Where can you find cities, towns, and streets but no people?";
            string riddle3CorrectAnswer = "a map";
            string riddle3UserAnswer = "";

            string riddle4 = "It’s been around for millions of years, but is never more than a month old. What is it?";
            string riddle4CorrectAnswer = "the moon";
            string riddle4UserAnswer = "";


            // = = = = = = = = = =  T R U E - O R - F A L S E = = = = = = = = = = 

            string trueOrFalse1 = "A cross between a horse and a zebra is called a 'Hobra'";
            string trueOrFalse1CorrectAnswer = "False";
            string trueOrFalse1UserAnswer = "";

            string trueOrFalse2 = "Hot and cold water sound the same when poured";
            string trueOrFalse2CorrectAnswer = "False";
            string trueOrFalse2UserAnswer = "";

            string trueOrFalse3 = "Fish cannot blink";
            string trueOrFalse3CorrectAnswer = "True";
            string trueOrFalse3UserAnswer = "";

            string trueOrFalse4 = "Coffee is made from berries";
            string trueOrFalse4CorrectAnswer = "True ";
            string trueOrFalse4UserAnswer = "";

            // = = = = = = = = = =  D I C E = = = = = = = = = = 

            Random rd1 = new Random();
            int RiddleEasyDice = rd1.Next(1, 4);
            //int Riddle4Dice = 2;

            Random rd2 = new Random();
            int Question2Dice = rd2.Next(1, 2);




            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            Console.SetWindowSize(150, 55);

            Console.WriteLine("");
            Console.WriteLine("         Welcome to.....");
            Console.WriteLine("");
            Console.WriteLine(
                "                  _____                                  _    _                               _    _       ");
            Console.WriteLine(
                "                 |  ___|                                | |  | |                             | |  | |      ");
            Console.WriteLine(
                "                 | |__   ___   ___   __ _  _ __    ___  | |_ | |__    ___    ___   __ _  ___ | |_ | |  ___ ");
            Console.WriteLine(
                @"                 |  __| / __| / __| / _` || '_ \  / _ \ | __|| '_ \  / _ \  / __| / _` |/ __|| __|| | / _ \");
            Console.WriteLine(
                @"                 | |___ \__ \| (__ | (_| || |_) ||  __/ | |_ | | | ||  __/ | (__ | (_| |\__ \| |_ | ||  __/");
            Console.WriteLine(
                @"                 \____/ |___/ \___| \__,_|| .__/  \___|  \__||_| |_| \___|  \___| \__,_||___/ \__||_| \___|");
            Console.WriteLine(
                "                                          | |                                                              ");
            Console.WriteLine("                                          |_|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     Do you have what it takes to escape the castle? ");
            Console.WriteLine("     In this game you will face riddles and  questions ranging in difficulties");
            Console.WriteLine(
                "     If you can answer all of the questions correctly and pass through the levels you will win. ");
            //Console.WriteLine("    There are 3 levels to the game: ");
            //Console.WriteLine("");
            //Console.WriteLine("     Level 1: Roll the dice in front of you to choose your path, correctly answer the riddle and you will be put through to level 2.");
            //Console.WriteLine("     if you guess incorrectly you will be moved onto a question, answer this correctly to be moved on to level 2.");
            //Console.WriteLine("     If you answer that incorrectly you will be then put back in the cells to roll the dice again.");
            //Console.WriteLine("");
            //Console.WriteLine("     Level 2:Roll the dice in front of you to choose your path, correctly answer the questions and you will be be able to open");
            //Console.WriteLine("     the locked chest to answer a mathematical scroll that upon typing in the correct answer will open the door.");
            //Console.WriteLine("     If you answer any incorrectly you will be then put back in the cells to roll the dice again.");

            //Console.WriteLine("     Level 3: Roll the dice in front of you to choose your path, correctly answer the riddle and you will be put through to level 2.");
            //Console.WriteLine("     if you guess incorrectly you will be moved onto a question, answer this correctly to be moved on to level 2.");
            //Console.WriteLine("     If you answer that incorrectly you will be then put back in the cells to roll the dice again.");
            //Console.WriteLine("");
            //Console.WriteLine("     Level 2:Roll the dice in front of you to choose your path, correctly answer the questions and you will be be able to open");
            //Console.WriteLine("     the locked chest to answer a mathematical scroll that upon typing in the correct answer will open the door.");
            //Console.WriteLine("     If you answer any incorrectly you will be then put back in the cells to roll the dice again.");
            Console.WriteLine("");
            Console.WriteLine(" Press enter to continue...");
            Console.ReadLine();

            Console.WriteLine(@"  _                _   _         _____ _           ___     _ _     ");
            Console.WriteLine(@" | |   _____ _____| | / |  ___  |_   _| |_  ___   / __|___| | |___ ");
            Console.WriteLine(@" | |__/ -_) V / -_) | | | |___|   | | | ' \/ -_) | (__/ -_) | (_-< ");
            Console.WriteLine(@" |____\___|\_/\___|_| |_|         |_| |_||_\___|  \___\___|_|_/__/ ");
            Console.WriteLine(@"                                                                  ");
            Console.WriteLine(@"                                                                                  ");

            Console.WriteLine("                            ===============================");
            Console.WriteLine("                            ||     ||<(.)>||<(.)>||     || ");
            Console.WriteLine("                            ||    _||     ||     ||_    || ");
            Console.WriteLine("                            ||   (__D     ||     C__)   || ");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||     ||     ||     ||     ||");
            Console.WriteLine("                            ===============================");


            Console.WriteLine("Roll the d4 dice to start the level?");
            Console.WriteLine("Y/N");
            userYNagree = Console.ReadLine();
            if (userYNagree.ToUpper() == ynAgree.ToUpper())
            {
                Console.Write("Lets begin..");
            }
            else if (userYNagree.ToUpper() == ynDisagree.ToUpper())
            {
                Environment.Exit(1);
            }

            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.Write("You throw the d4 at the floor...");
            Console.WriteLine("");
            Console.WriteLine(@"    _______            ");
            Console.WriteLine(@"  /\       \           ");
            Console.WriteLine(@" /()\   ()  \          ");
            Console.WriteLine(@"/    \_______\         ");
            Console.WriteLine(@"\    /()     /         ");
            Console.WriteLine(@" \()/   ()  /          ");
            Console.WriteLine(@"  \/_____()/");
            Console.WriteLine("");
            Console.WriteLine("and roll a..." + RiddleEasyDice + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            // = = = = = = = = = = D I C E - R O L L - 1 = = = = = = = = = = 

            if (RiddleEasyDice == 1)
            {
                Console.WriteLine(riddle1);
                riddle1UserAnswer = Console.ReadLine();
                if (riddle1UserAnswer.ToLower() == riddle1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Moving on to level 2....");
                    Console.ReadLine();
                }

                if (riddle1UserAnswer.ToLower() != riddle1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, Redeem yourself by answering this question..");
                    Console.WriteLine("");
                    Console.WriteLine(trueOrFalse1);
                    trueOrFalse1UserAnswer = Console.ReadLine();
                    if (trueOrFalse1UserAnswer.ToLower() == trueOrFalse1CorrectAnswer.ToLower())

                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done, you can answer an easy question correctly. Time for level 2.");
                        Console.ReadLine();
                    }

                    if (trueOrFalse1UserAnswer.ToLower() != trueOrFalse1CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorrect. Better luck next time.");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                }
            }

            // = = = = = = = = = = D I C E - R O L L - 2 = = = = = = = = = = 

            else if (RiddleEasyDice == 2)
            {
                Console.WriteLine(riddle2);
                riddle2UserAnswer = Console.ReadLine();
                if (riddle2UserAnswer.ToLower() == riddle2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Moving on to level 2....");
                    Console.ReadLine();
                }

                if (riddle2UserAnswer.ToLower() != riddle2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, Redeem yourself by answering this question..");
                    Console.WriteLine("");
                    Console.WriteLine(trueOrFalse2);
                    trueOrFalse2UserAnswer = Console.ReadLine();
                    if (trueOrFalse2UserAnswer.ToLower() == trueOrFalse2CorrectAnswer.ToLower())

                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done, you can answer an easy question correctly. Time for level 2.");
                        Console.ReadLine();
                    }

                    if (trueOrFalse2UserAnswer.ToLower() != trueOrFalse2CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorrect. Better luck next time.");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                }
            }

            // = = = = = = = = = =  D I C E - R O L L - 3 = = = = = = = = = = 

            else if (RiddleEasyDice == 3)
            {
                Console.WriteLine(riddle3);
                riddle3UserAnswer = Console.ReadLine();
                if (riddle3UserAnswer.ToLower() == riddle3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Moving on to level 2....");
                    Console.ReadLine();
                }
                if (riddle3UserAnswer.ToLower() != riddle3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, Redeem yourself by answering this question..");
                    Console.WriteLine("");
                    Console.WriteLine(trueOrFalse3);
                    trueOrFalse3UserAnswer = Console.ReadLine();
                    if (trueOrFalse3UserAnswer.ToLower() == trueOrFalse3CorrectAnswer.ToLower())

                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done, you can answer an easy question correctly. Time for level 2.");
                        Console.ReadLine();
                    }

                    if (trueOrFalse3UserAnswer.ToLower() != trueOrFalse3CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorrect. Better luck next time.");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                }

                Console.ReadLine();
            }

            // = = = = = = = = = =  D I C E - R O L L - 4 = = = = = = = = = = 

            else if (RiddleEasyDice == 4)
            {
                Console.WriteLine(riddle4);
                riddle4UserAnswer = Console.ReadLine();
                if (riddle4UserAnswer.ToLower() == riddle4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Moving on to level 2....");
                    Console.ReadLine();
                }

                if (riddle4UserAnswer.ToLower() != riddle4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, Redeem yourself by answering this question..");
                    Console.WriteLine("");
                    Console.WriteLine(trueOrFalse4);
                    trueOrFalse4UserAnswer = Console.ReadLine();
                    if (trueOrFalse4UserAnswer.ToLower() == trueOrFalse4CorrectAnswer.ToLower())

                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done, you can answer an easy question correctly. Time for level 2.");
                        Console.ReadLine();
                    }

                    if (trueOrFalse4UserAnswer.ToLower() != trueOrFalse4CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorrect. Better luck next time.");
                        Console.ReadLine();
                        Environment.Exit(1);
                    }

                }

                Console.ReadLine();
            }



            // = = = = = = = = = = L E V E L - 2 = = = = = = = = = = 


            // = = = = = = = = = =  D I C E = = = = = = = = = = 

            Random rd3 = new Random();
            //int RiddleMediumDice = rd3.Next(1, 5);
            int RiddleMediumDice = 1;

            // Random rd4 = new Random();
            // int QuestionHardDice = rd4.Next(1, 2);

            // = = = = = = = = = = R I D D L E  = = = = = = = = = = = =  
            string riddle5 = "I may be simple, I may be complex; I may have a name, but no gender or sex; I am often a question, or statements as a setup; I tend to have an answer, 'til you find it I won't let up. What am I?";
            string riddle5CorrectAnswer = "A riddle";
            string riddle5UserAnswer = "";

            string riddle6 = "";
            string riddle6CorrectAnswer = "";
            string riddle6UserAnswer = "";

            string riddle7 = "";
            string riddle7CorrectAnswer = "";
            string riddle7UserAnswer = "";

            string riddle8 = "";
            string riddle8CorrectAnswer = "";
            string riddle8UserAnswer = "";

            // = = = = = = = = = = G E N E R A L - K N O W L E D G E = = = = = = = = = = 
            string generalKnowledge1 = "Pure gold is how many carats?";
            string generalKnowledge1CorrectAnswer = "24 carats";
            string generalKnowledge1UserAnswer = "";

            string generalKnowledge2 = "";
            string generalKnowledge2CorrectAnswer = "";
            string generalKnowledge2UserAnswer = "";

            string generalKnowledge3 = "";
            string generalKnowledge3CorrectAnswer = "";
            string generalKnowledge3UserAnswer = "";

            string generalKnowledge4 = "";
            string generalKnowledge4CorrectAnswer = "";
            string generalKnowledge4UserAnswer = "";

            // = = = = = = = = = = M A T H S - Q U E S T I O N = = = = = = = = = = 

            string mathQuestion1 = "10 x 20";
            string mathQuestion1CorrectAnswer = "200";
            string mathQuestion1UserAnswer = "";

            string mathQuestion2 = "";
            string mathQuestion2CorrectAnswer = "";
            string mathQuestion2UserAnswer = "";

            string mathQuestion3 = "";
            string mathQuestion3CorrectAnswer = "";
            string mathQuestion3UserAnswer = "";

            string mathQuestion4 = "";
            string mathQuestion4CorrectAnswer = "";
            string mathQuestion4UserAnswer = "";

            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

            Console.WriteLine("==============================================================================================================================================");
            Console.WriteLine(@"  _                    _   ___             _______ _             _____          _   _        _____                   ");
            Console.WriteLine(@" | |                  | | |__ \           |__   __| |           / ____|        | | | |      |  __ \                  ");
            Console.WriteLine(@" | |     _____   _____| |    ) |  ______     | |  | |__   ___  | |     __ _ ___| |_| | ___  | |  | | ___   ___  _ __ ");
            Console.WriteLine(@" | |    / _ \ \ / / _ \ |   / /  |______|    | |  | '_ \ / _ \ | |    / _` / __| __| |/ _ \ | |  | |/ _ \ / _ \| '__|");
            Console.WriteLine(@" | |___|  __/\ V /  __/ |  / /_              | |  | | | |  __/ | |___| (_| \__ \ |_| |  __/ | |__| | (_) | (_) | |   ");
            Console.WriteLine(@" |______\___| \_/ \___|_| |____|             |_|  |_| |_|\___|  \_____\__,_|___/\__|_|\___| |_____/ \___/ \___/|_|   ");
            Console.WriteLine(@"                                                                                                                  ");

            Console.WriteLine("____________________________________________");
            Console.WriteLine("|____________________________________________|");
            Console.WriteLine("|__||  ||___||  |_|___|___|__|  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|  |___|___|___||  |__|__|  |__||");
            Console.WriteLine("|__||  ||___||  |_|___|___|__|  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine("|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine("|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine("|__||  ||___||  |   O|| |O   |  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine("|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine("||__|  |__|__|__|____||_|____|  |__|__|  |__||");
            Console.WriteLine("|LLL|  |LLLLL|______________||  |LLLLL|  |LLL|");
            Console.WriteLine("|LLL|  |LLL|______________|  |  |LLLLL|  |LLL|");
            Console.WriteLine("|LLL|__|L|______________|____|__|LLLLL|__|LLL|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("You've made it to the internal castle door. Roll the d4 dice to continue.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Roll the d4 dice to start the level?");
            Console.WriteLine("");
            Console.WriteLine("Y/N");
            Console.WriteLine("");
            userYNagree = Console.ReadLine();
            if (userYNagree.ToUpper() == ynAgree.ToUpper())
            {
                Console.WriteLine("");
                Console.Write("Lets begin..");
                Console.WriteLine("");
            }
            else if (userYNagree.ToUpper() == ynDisagree.ToUpper())
            {
                Environment.Exit(1);
            }
            Console.WriteLine("");
            Console.WriteLine("You throw the d4 at the floor...");
            Console.WriteLine("");
            Console.WriteLine(@"    _______            ");
            Console.WriteLine(@"  /\       \           ");
            Console.WriteLine(@" /()\   ()  \          ");
            Console.WriteLine(@"/    \_______\         ");
            Console.WriteLine(@"\    /()     /         ");
            Console.WriteLine(@" \()/   ()  /          ");
            Console.WriteLine(@"  \/_____()/");
            Console.WriteLine("");
            Console.WriteLine("and roll a..." + RiddleMediumDice + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            // = = = = = = = = = = D I C E - R O L L - 1 = = = = = = = = = = 

            if (RiddleMediumDice == 1)
            {
                Console.WriteLine(riddle5);
                riddle5UserAnswer = Console.ReadLine();
                if (riddle5UserAnswer.ToLower() == riddle5CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge1);
                    generalKnowledge1UserAnswer = Console.ReadLine();
                    if (generalKnowledge1UserAnswer.ToLower() == generalKnowledge1CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done! Just a single question left before level 3...");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion1);
                        mathQuestion1UserAnswer = Console.ReadLine();
                    }

                }

                if (mathQuestion1UserAnswer.ToLower() == mathQuestion1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                }

                Console.WriteLine("Nice. Time for level 3...");
                Console.ReadLine();

                if (mathQuestion1UserAnswer.ToLower() != mathQuestion1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Environment.Exit(1);

                }
                if (riddle5UserAnswer.ToLower() != riddle5CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Environment.Exit(1);

                }
                if (generalKnowledge1UserAnswer.ToLower() != generalKnowledge1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Environment.Exit(1);
                }




            }

            // = = = = = = = = = = D I C E - R O L L - 2 = = = = = = = = = = 

            else if (RiddleMediumDice == 2)
            {

            }

            // = = = = = = = = = =  D I C E - R O L L - 3 = = = = = = = = = = 

            else if (RiddleMediumDice == 3)
            {

            }

            // = = = = = = = = = =  D I C E - R O L L - 4 = = = = = = = = = = 

            else if (RiddleMediumDice == 4)
            {



            }















            Console.ReadLine();

        }
    }
}
