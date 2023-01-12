using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheCastle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - - - - - - - - - - V A R I A B L E S - - - - - - - - - - 

            // - - - - - - - - - - L E V E L - 1 - - - - - - - - - - 

            string ynAgree = "Y";
            string userYNagree = "";

            string ynDisagree = "N";
            string userYNdisagree = "";

            // - - - - - - - - - - R I D D L E S - - - - - - - - - - 

            string riddle1 = "What has 4 legs but is not alive?";
            string riddle1CorrectAnswer = "a chair";
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


            // - - - - - - - - - - T R U E - O R - F A L S E - - - - - - - - - 

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

            // - - - - - - - - - - D I C E - - - - - - - - - - 

            Random rd1 = new Random();
            int Riddle4Dice = rd1.Next(1, 4);

            Random rd2 = new Random();
            int Question2Dice = rd2.Next(1, 2);


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - 
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

            Console.WriteLine(@"            _                _   _         _   _                 _ _     ");
            Console.WriteLine(@"           | |   _____ _____| | / |  ___  | |_| |_  ___   __ ___| | |___ ");
            Console.WriteLine(@"           | |__/ -_) V / -_) | | | |___| |  _| ' \/ -_) / _/ -_) | (_-< ");
            Console.WriteLine(@"           |____\___|\_/\___|_| |_|        \__|_||_\___| \__\___|_|_/__/ ");

            Console.WriteLine("                            ===============================");
            Console.WriteLine("                            ||     ||<(.)>||<(.)>||     || ");
            Console.WriteLine("                            ||    _||     ||     ||_    || ");
            Console.WriteLine("                            ||   (__D     ||     C__)   || ");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||   (__D     ||     C__)   ||");
            Console.WriteLine("                            ||     ||     ||     ||     ||");
            Console.WriteLine("                            ===============================");


            Console.WriteLine("Roll the dice to start the level?");
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


            Console.Write("You throw the dice at the floor and roll a... " + Riddle4Dice + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            if (Riddle4Dice == 1)
            {
                Console.WriteLine(riddle1);
                riddle1UserAnswer = Console.ReadLine();
                if (riddle1UserAnswer.ToLower() == riddle1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct. Moving on to level 2....");
                }

                if (riddle1UserAnswer.ToLower() != riddle1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, better luck next time.");
                    Console.ReadLine();
                    {
                        Environment.Exit(1);
                        ;
                        
                    }
                    
                }
            }
            else if (Riddle4Dice == 2)
            {
                Console.WriteLine(riddle2);
                riddle2UserAnswer = Console.ReadLine();
                if (riddle2UserAnswer.ToLower() == riddle2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct. Moving on to level 2....");
                }

                if (riddle2UserAnswer.ToLower() != riddle2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, better luck next time.");
                    Console.ReadLine();
                    {
                        Environment.Exit(1);
                        ;
                        Console.ReadLine();
                    }
                }
                Console.ReadLine();
            }
            else if (Riddle4Dice == 3)
            {
                Console.WriteLine(riddle3);
                riddle3UserAnswer = Console.ReadLine();
                if (riddle3UserAnswer.ToLower() == riddle3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct. Moving on to level 2....");
                }

                if (riddle3UserAnswer.ToLower() != riddle3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, better luck next time.");
                    Console.ReadLine();
                    {
                        Environment.Exit(1);
                        ;
                        Console.ReadLine();
                    }
                }

                Console.ReadLine();
            }
            else if (Riddle4Dice == 4)
            {
                Console.WriteLine(riddle4);
                riddle4UserAnswer = Console.ReadLine();
                if (riddle4UserAnswer.ToLower() == riddle4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct. Moving on to level 2....");
                }

                if (riddle4UserAnswer.ToLower() != riddle4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, better luck next time.");
                    Console.ReadLine();
                    {
                        Environment.Exit(1);
                        ;
                        Console.ReadLine();
                    }
                }

                Console.ReadLine();
            }

        }
    }
}
