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
            // = = = = = = = = = =  V A R I A B L E S = = = = = = = = = = 


            string ynAgree = "Y";
            string userYNagree = "";

            string ynDisagree = "N";
            //string userYNdisagree = "";

            // = = = = = = = = = =  D I C E = = = = = = = = = = 
            
            Random rd2 = new Random();
            int Question2Dice = rd2.Next(1, 2);




            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 
            Console.SetWindowSize(150, 55);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            Menu.Welcome();

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
            }
            else if (userYNagree.ToUpper() == ynDisagree.ToUpper())
            {
                return;
            }

            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");

            Dice dice = new Dice();
            int diceRoll = dice.RollDice();

            try
            {
                switch (diceRoll)
                {
                    case 1:
                        Riddle1 riddle1 = new Riddle1();
                        if (riddle1.GuessRiddle() == false)
                            return;
                        break;
                    case 2:
                        Riddle2 riddle2 = new Riddle2();

                        if (riddle2.GuessRiddle() == false)
                            return;
                        break;
                    case 3:
                        Riddle3 riddle3 = new Riddle3();
                        if (riddle3.GuessRiddle() == false)
                            return;
                        break;
                    case 4:
                        Riddle4 riddle4 = new Riddle4();
                        if (riddle4.GuessRiddle() == false)
                            return;
                        break;
                    default:
                        throw new Exception(
                            $"There was a malfunction on the dice roll and we don't know how to handle the value {diceRoll}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }


            // = = = = = = = = = = L E V E L - 2 = = = = = = = = = = 


            // = = = = = = = = = =  D I C E = = = = = = = = = = 

            Random rd3 = new Random();
            int level2Dice = rd3.Next(1, 5);
            //int RiddleMediumDice = 1;

            // Random rd4 = new Random();
            // int QuestionHardDice = rd4.Next(1, 2);

            // = = = = = = = = = = R I D D L E  = = = = = = = = = = = =  
            string riddle5 =
                $"I may be simple, I may be complex; I may have a name, but no gender or sex; I am often a question, or statements as a setup; {Environment.NewLine} I tend to have an answer, 'til you find it I won't let up. What am I?";
            string riddle5CorrectAnswer = "riddle";
            string riddle5UserAnswer = "";

            string riddle6 = "A slender body, a tiny eye, no matter what happens, I never cry. What am I?";
            string riddle6CorrectAnswer = "needle";
            string riddle6UserAnswer = "";

            string riddle7 = "I have hundreds of legs but I can only lean; You make me feel dirty so you feel clean. What am I?";
            string riddle7CorrectAnswer = "Broom";
            string riddle7UserAnswer = "";

            string riddle8 = "I am white, black and read all over. What am I?";
            string riddle8CorrectAnswer = "Newspaper";
            string riddle8UserAnswer = "";

            // = = = = = = = = = = G E N E R A L - K N O W L E D G E = = = = = = = = = = 
            string generalKnowledge1 = "Pure gold is how many carats?";
            string generalKnowledge1CorrectAnswer = "24";
            string generalKnowledge1UserAnswer = "";

            string generalKnowledge2 = "Scurvy is a disease resulting from the lack of which vitamin?";
            string generalKnowledge2CorrectAnswer = "C";
            string generalKnowledge2UserAnswer = "";

            string generalKnowledge3 = "How many valves does the heart have?";
            string generalKnowledge3CorrectAnswer = "4";
            string generalKnowledge3UserAnswer = "";

            string generalKnowledge4 = "Which metal has the chemical symbol \"Fe\"?";
            string generalKnowledge4CorrectAnswer = "Iron";
            string generalKnowledge4UserAnswer = "";

            // = = = = = = = = = = M A T H S - Q U E S T I O N = = = = = = = = = = 

            string mathQuestion1 = "10 x 20";
            string mathQuestion1CorrectAnswer = "200";
            string mathQuestion1UserAnswer = "";

            string mathQuestion2 = "How many hours in a week?";
            string mathQuestion2CorrectAnswer = "168";
            string mathQuestion2UserAnswer = "";

            string mathQuestion3 = "What is the total of all the internal angles of a triangle?";
            string mathQuestion3CorrectAnswer = "180";
            string mathQuestion3UserAnswer = "";

            string mathQuestion4 = "What is the name given to an angle that measures less than 90 degree?";
            string mathQuestion4CorrectAnswer = "Acute";
            string mathQuestion4UserAnswer = "";

            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

            Console.WriteLine(
                "==============================================================================================================================================");
            Console.WriteLine(
                @"  _                    _   ___             _______ _             _____          _   _        _____                   ");
            Console.WriteLine(
                @" | |                  | | |__ \           |__   __| |           / ____|        | | | |      |  __ \                  ");
            Console.WriteLine(
                @" | |     _____   _____| |    ) |  ______     | |  | |__   ___  | |     __ _ ___| |_| | ___  | |  | | ___   ___  _ __ ");
            Console.WriteLine(
                @" | |    / _ \ \ / / _ \ |   / /  |______|    | |  | '_ \ / _ \ | |    / _` / __| __| |/ _ \ | |  | |/ _ \ / _ \| '__|");
            Console.WriteLine(
                @" | |___|  __/\ V /  __/ |  / /_              | |  | | | |  __/ | |___| (_| \__ \ |_| |  __/ | |__| | (_) | (_) | |   ");
            Console.WriteLine(
                @" |______\___| \_/ \___|_| |____|             |_|  |_| |_|\___|  \_____\__,_|___/\__|_|\___| |_____/ \___/ \___/|_|   ");
            Console.WriteLine(
                @"                                                                                                                  ");

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
                return;
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
            Console.WriteLine("and roll a..." + level2Dice + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            // = = = = = = = = = = D I C E - R O L L - 1 = = = = = = = = = = 

            if (level2Dice == 1)
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
                    Console.WriteLine("Nice. Time for level 3...");
                    Console.ReadLine();
                }


                if (mathQuestion1UserAnswer.ToLower() != mathQuestion1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle5UserAnswer.ToLower() != riddle5CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (generalKnowledge1UserAnswer.ToLower() != generalKnowledge1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }




            }

            // = = = = = = = = = = D I C E - R O L L - 2 = = = = = = = = = = 

            else if (level2Dice == 2)
            {
                Console.WriteLine(riddle6);
                riddle6UserAnswer = Console.ReadLine();
                if (riddle6UserAnswer.ToLower() == riddle6CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge2);
                    generalKnowledge2UserAnswer = Console.ReadLine();
                    if (generalKnowledge2UserAnswer.ToLower() == generalKnowledge2CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done! Just a single question left before level 3...");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion2);
                        mathQuestion2UserAnswer = Console.ReadLine();
                    }

                }

                if (mathQuestion2UserAnswer.ToLower() == mathQuestion2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nice. Time for level 3...");
                    Console.ReadLine();
                }


                if (mathQuestion2UserAnswer.ToLower() != mathQuestion2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle6UserAnswer.ToLower() != riddle6CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (generalKnowledge2UserAnswer.ToLower() != generalKnowledge2CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }
            }

            // = = = = = = = = = =  D I C E - R O L L - 3 = = = = = = = = = = 

            else if (level2Dice == 3)
            {
                Console.WriteLine(riddle7);
                riddle7UserAnswer = Console.ReadLine();
                if (riddle7UserAnswer.ToLower() == riddle7CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge3);
                    generalKnowledge3UserAnswer = Console.ReadLine();
                    if (generalKnowledge3UserAnswer.ToLower() == generalKnowledge3CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done! Just a single question left before level 3...");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion3);
                        mathQuestion3UserAnswer = Console.ReadLine();
                    }

                }

                if (mathQuestion3UserAnswer.ToLower() == mathQuestion3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Nice. Time for level 3...");
                    Console.ReadLine();
                }


                if (mathQuestion3UserAnswer.ToLower() != mathQuestion3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle7UserAnswer.ToLower() != riddle7CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (generalKnowledge3UserAnswer.ToLower() != generalKnowledge3CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }
            }

            // = = = = = = = = = =  D I C E - R O L L - 4 = = = = = = = = = = 

            else if (level2Dice == 4)
            {
                Console.WriteLine(riddle8);
                riddle8UserAnswer = Console.ReadLine();
                if (riddle8UserAnswer.ToLower() == riddle8CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge4);
                    generalKnowledge4UserAnswer = Console.ReadLine();
                    if (generalKnowledge4UserAnswer.ToLower() == generalKnowledge4CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Well done! Just a single question left before level 3...");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion4);
                        mathQuestion4UserAnswer = Console.ReadLine();
                    }

                }

                if (mathQuestion4UserAnswer.ToLower() == mathQuestion4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Well Done.... Time for level 3...");
                    Console.ReadLine();
                }


                if (mathQuestion4UserAnswer.ToLower() != mathQuestion4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle8UserAnswer.ToLower() != riddle8CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (generalKnowledge4UserAnswer.ToLower() != generalKnowledge4CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, time for you to go back to the cells.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }
            }

            // = = = = = = = = = = L E V E L - 3 = = = = = = = = = = 


            // = = = = = = = = = =  D I C E = = = = = = = = = = 
            Random rd4 = new Random();
            int level3Dice = rd3.Next(1, 5);
            //int level3Dice = 1;

            // = = = = = = = = = = R I D D L E S = = = = = = = = = = 

            string riddle9 = "You measure my life in hours and I serve you by expiring. I’m quick when I’m thin and slow when I’m fat. The wind is my enemy.";
            string riddle9CorrectAnswer = "candle";
            string riddle9UserAnswer = "";

            string riddle10 = "I have keys, but no locks and space, and no rooms. You can enter, but you can’t go outside. What am I?";
            string riddle10CorrectAnswer = "keyboard";
            string riddle10UserAnswer = "";

            string riddle11 = "What is able to go up a chimney when down but unable to go down a chimney when up?";
            string riddle11CorrectAnswer = "umbrella";
            string riddle11UserAnswer = "";

            string riddle12 = "What is always in front of you but can’t be seen?";
            string riddle12CorrectAnswer = "future";
            string riddle12UserAnswer = "";

            string riddle13 = "I shave every day, but my beard stays the same. What am I?";
            string riddle13CorrectAnswer = "barber";
            string riddle13UserAnswer = "";

            // = = = = = = = = = = G E N E R A L - K N O W L E D G E = = = = = = = = = = 

            string generalKnowledge5 = "Which country is brie cheese originally from?";
            string generalKnowledge5CorrectAnswer = "France";
            string generalKnowledge5UserAnswer = "";

            string generalKnowledge6 = "Which planet is closest to the sun?";
            string generalKnowledge6CorrectAnswer = "Mercury";
            string generalKnowledge6UserAnswer = "";

            string generalKnowledge7 = "What fruit takes the scientific name Mangifera indica?";
            string generalKnowledge7CorrectAnswer = "Mango";
            string generalKnowledge7UserAnswer = "";

            string generalKnowledge8 = "What grain is the Japanese spirit Sake made from?";
            string generalKnowledge8CorrectAnswer = "Rice";
            string generalKnowledge8UserAnswer = "";

            string generalKnowledge9 = "Which dish was voted as the national dish of the UK?";
            string generalKnowledge9CorrectAnswer = "Chicken Tikka";
            string generalKnowledge9UserAnswer = "";

            // = = = = = = = = = = T R U E - O R - F A L S E = = = = = = = = = = 

            string trueOrFalse5 = "True or false: An octopus has seven hearts. ";
            string trueOrFalse5CorrectAnswer = "False";
            string trueOrFalse5UserAnswer = "";

            string trueOrFalse6 = "True or false: Greenland is the largest island in the world.";
            string trueOrFalse6CorrectAnswer = "True";
            string trueOrFalse6UserAnswer = "";

            string trueOrFalse7 = "True or false: Venezuela is home to the world’s highest waterfall.";
            string trueOrFalse7CorrectAnswer = "True";
            string trueOrFalse7UserAnswer = "";

            string trueOrFalse8 = "True or false: The average human sneeze can be clocked at 100 miles an hour.";
            string trueOrFalse8CorrectAnswer = "True";
            string trueOrFalse8UserAnswer = "";

            string trueOrFalse9 = "True or false: Infants have more bones than adults";
            string trueOrFalse9CorrectAnswer = "True";
            string trueOrFalse9UserAnswer = "";

            // = = = = = = = = = = M A T H S = = = = = = = = = = 

            string mathQuestion5 = "If 1=3\r\n\r\n2=3\r\n\r\n3=5\r\n\r\n4=4\r\n\r\n5=4\r\n\r\nThen, 6=?";
            string mathQuestion5CorrectAnswer = "3";
            string mathQuestion5UserAnswer = "";

            string mathQuestion6 = "Sally is 54 years old and her mother is 80, how many years ago was Sally’s mother twice her age?";
            string mathQuestion6CorrectAnswer = "41";
            string mathQuestion6UserAnswer = "";

            string mathQuestion7 = "There is a three-digit number. The second digit is four times as big as the third digit, while the first digit is three less than the second digit. What is the number?";
            string mathQuestion7CorrectAnswer = "141";
            string mathQuestion7UserAnswer = "";

            string mathQuestion8 = "36, 34, 30, 28, 24, … What number should come next?";
            string mathQuestion8CorrectAnswer = "22";
            string mathQuestion8UserAnswer = "";

            string mathQuestion9 = "Look at this series: 53, 53, 40, 40, 27, 27, … What number should come next?";
            string mathQuestion9CorrectAnswer = "14";
            string mathQuestion9UserAnswer = "";



            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

            Console.WriteLine(
                "==============================================================================================================================================");
            Console.WriteLine(@"  _                   _   _____            ____          _   _         ____                           _     ");
            Console.WriteLine(@" | |    _____   _____| | |___ /           / ___|__ _ ___| |_| | ___   / ___|_ __ ___  _   _ _ __   __| |___ ");
            Console.WriteLine(@" | |   / _ \ \ / / _ \ |   |_ \   _____  | |   / _` / __| __| |/ _ \ | |  _| '__/ _ \| | | | '_ \ / _` / __|");
            Console.WriteLine(@" | |__|  __/\ V /  __/ |  ___) | |_____| | |__| (_| \__ \ |_| |  __/ | |_| | | | (_) | |_| | | | | (_| \__ \");
            Console.WriteLine(@" |_____\___| \_/ \___|_| |____/           \____\__,_|___/\__|_|\___|  \____|_|  \___/ \__,_|_| |_|\__,_|___/");
            Console.WriteLine("");
            Console.WriteLine(@"                                       /\");
            Console.WriteLine(@"                                      /`:\");
            Console.WriteLine(@"                                     /`'`:\");
            Console.WriteLine(@"                                    /`'`'`:\");
            Console.WriteLine(@"                                   /`'`'`'`:\");
            Console.WriteLine(@"                                  /`'`'`'`'`:\");
            Console.WriteLine(@"                                   |`'`'`'`:|");
            Console.WriteLine(@"     _ _  _  _  _                  |] ,-.  :|_  _  _  _");
            Console.WriteLine(@"    ||| || || || |                 |  |_| ||| || || || |");
            Console.WriteLine(@"    |`' `' `' `'.|                 | _'=' |`' `' `' `'.|");
            Console.WriteLine(@"    :          .:;                 |'-'   :          .:;");
            Console.WriteLine(@"     \-..____..:/  _  _  _  _  _  _| _  _'-\-..____..:/");
            Console.WriteLine(@"      :--------:_,' || || || || || || || `.::--------:");
            Console.WriteLine(@"      |]     .:|:.  `' `'_`' `' `' `' `'    | '-'  .:|");
            Console.WriteLine(@"      |  ,-. .[|:._     '-' ____     ___    |   ,-.'-|");
            Console.WriteLine(@"      |  | | .:|'--'_     ,'____`.  '---'   |   | |.:|");
            Console.WriteLine(@"      |  |_| .:|:.'--' ()/,| |`|`.\()   __  |   |_|.:|");
            Console.WriteLine(@"      |  '=' .:|:.     |::_|_|_|\|::   '--' |  _'='.:|");
            Console.WriteLine(@"      | __   .:|:.     ;||-,-,-,-,|;        | '--' .:|");
            Console.WriteLine(@"      |'--'  .:|:. _  ; ||       |:|        |      .:|");
            Console.WriteLine(@"      |      .:|:.'-':  ||       |;|     _  |]     _:|");
            Console.WriteLine(@"      |      '-|:.   ;  ||       :||    '-' |     '--|");
            Console.WriteLine(@"      |  _   .:|].  ;   ||       ;||]       |   _  .:|");
            Console.WriteLine(@"      | '-'  .:|:. :   [||      ;|||        |  '-' .:|");
            Console.WriteLine(@"  ,', ;._____.::-- ;---->'-,--,:-'<'--------;._____.::.`.");
            Console.WriteLine(@" ((  (          )_;___,' ,' ,  ; //________(          ) ))");
            Console.WriteLine(@"  `. _`--------' : -,' ' , ' '; //-       _ `--------' ,'");
            Console.WriteLine(@"       __  .--'  ;,' ,'  ,  ': //    -.._    __  _.-  -");
            Console.WriteLine(@"   `-   --    _ ;',' ,'  ,' ,;/_  -.       ---    _,");
            Console.WriteLine(@"       _,.   /-:,_,_,_,_,_,_(/:-\   ,     ,.    _");
            Console.WriteLine(@"     -'   `-'--'-'-'-'-'-'-'-''--'-' `-'`'  `'`' `");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("You've managed to break out of the castle door. You start running towards the outside door and it slams shut. Roll the d4 dice to break out.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"  _            _");
            Console.WriteLine(@" / \          / \");
            Console.WriteLine(@" |~|          |~|");
            Console.WriteLine(@"#""'""|'""'""'""'""|""'""|""");
            Console.WriteLine(@"#   |  _.._  |   |");
            Console.WriteLine(@"#   |.'    `.|   |");
            Console.WriteLine(@"#   |        |   |");
            Console.WriteLine(@"#   |.   /~~/~~/~~/");
            Console.WriteLine(@"#   | './  /  /  /");
            Console.WriteLine(@"#   |  /--/--/--/|");
            Console.WriteLine(@"#   | /  /  /  / |");
            Console.WriteLine(@"#   |/--/--/--/  |");
            Console.WriteLine(@"#   |========#   |");
            Console.WriteLine("");
            Console.WriteLine("Roll the d4 dice to start the level?");
            Console.WriteLine("");
            Console.WriteLine("Y/N");
            Console.WriteLine("");
            userYNagree = Console.ReadLine();
            if (userYNagree.ToUpper() == ynAgree.ToUpper())
            {
                Console.WriteLine("");
                Console.Write("Good luck..");
                Console.WriteLine("");
            }
            else if (userYNagree.ToUpper() == ynDisagree.ToUpper())
            {
                return;
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
            Console.WriteLine("and roll a..." + level3Dice + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            // = = = = = = = = = = D I C E - R O L L - 1 = = = = = = = = = = 

            if (level3Dice == 1)
            {
                Console.WriteLine(riddle9);
                riddle9UserAnswer = Console.ReadLine();
                if (riddle9UserAnswer.ToLower() == riddle9CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge5);
                    generalKnowledge5UserAnswer = Console.ReadLine();
                    if (generalKnowledge5UserAnswer.ToLower() == generalKnowledge5CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct. Question 3:");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion5);
                        mathQuestion5UserAnswer = Console.ReadLine();
                        if (mathQuestion5UserAnswer.ToLower() == mathQuestion5CorrectAnswer.ToLower())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Correct. Last question... :");
                            Console.WriteLine("");
                            Console.WriteLine(trueOrFalse5);
                            trueOrFalse5UserAnswer = Console.ReadLine();
                            if (trueOrFalse5UserAnswer.ToLower() == trueOrFalse5CorrectAnswer.ToLower())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You've managed to answer all of the questions correctly! You climb the drawbridge up and make a run for it...");
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                if (mathQuestion1UserAnswer.ToLower() != mathQuestion1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle9UserAnswer.ToLower() != riddle9CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (generalKnowledge1UserAnswer.ToLower() != generalKnowledge1CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (trueOrFalse5UserAnswer.ToLower() != trueOrFalse5CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

            }

            // = = = = = = = = = = D I C E - R O L L - 2 = = = = = = = = = = 

            else if (level3Dice == 2)
            {
                Console.WriteLine(riddle10);
                riddle10UserAnswer = Console.ReadLine();
                if (riddle10UserAnswer.ToLower() == riddle10CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge6);
                    generalKnowledge6UserAnswer = Console.ReadLine();
                    if (generalKnowledge6UserAnswer.ToLower() == generalKnowledge6CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct. Question 3:");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion6);
                        mathQuestion6UserAnswer = Console.ReadLine();
                        if (mathQuestion6UserAnswer.ToLower() == mathQuestion6CorrectAnswer.ToLower())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Correct. Last question... :");
                            Console.WriteLine("");
                            Console.WriteLine(trueOrFalse6);
                            trueOrFalse6UserAnswer = Console.ReadLine();
                            if (trueOrFalse6UserAnswer.ToLower() == trueOrFalse6CorrectAnswer.ToLower())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You've managed to answer all of the questions correctly! You climb the drawbridge up and make a run for it...");
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                if (mathQuestion6UserAnswer.ToLower() != mathQuestion6CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle10UserAnswer.ToLower() != riddle10CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (generalKnowledge6UserAnswer.ToLower() != generalKnowledge6CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (trueOrFalse6UserAnswer.ToLower() != trueOrFalse6CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

            }

            // = = = = = = = = = =  D I C E - R O L L - 3 = = = = = = = = = = 

            else if (level3Dice == 3)
            {
                Console.WriteLine(riddle11);
                riddle11UserAnswer = Console.ReadLine();
                if (riddle11UserAnswer.ToLower() == riddle11CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge7);
                    generalKnowledge7UserAnswer = Console.ReadLine();
                    if (generalKnowledge7UserAnswer.ToLower() == generalKnowledge7CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct. Question 3:");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion7);
                        mathQuestion7UserAnswer = Console.ReadLine();
                        if (mathQuestion7UserAnswer.ToLower() == mathQuestion7CorrectAnswer.ToLower())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Correct. Last question... :");
                            Console.WriteLine("");
                            Console.WriteLine(trueOrFalse7);
                            trueOrFalse7UserAnswer = Console.ReadLine();
                            if (trueOrFalse7UserAnswer.ToLower() == trueOrFalse7CorrectAnswer.ToLower())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You've managed to answer all of the questions correctly! You climb the drawbridge up and make a run for it...");
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                if (mathQuestion7UserAnswer.ToLower() != mathQuestion7CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle11UserAnswer.ToLower() != riddle11CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (generalKnowledge7UserAnswer.ToLower() != generalKnowledge7CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (trueOrFalse7UserAnswer.ToLower() != trueOrFalse7CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

            }

            // = = = = = = = = = =  D I C E - R O L L - 4 = = = = = = = = = = 

            else if (level3Dice == 4)
            {
                Console.WriteLine(riddle12);
                riddle12UserAnswer = Console.ReadLine();
                if (riddle12UserAnswer.ToLower() == riddle12CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge8);
                    generalKnowledge8UserAnswer = Console.ReadLine();
                    if (generalKnowledge8UserAnswer.ToLower() == generalKnowledge8CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct. Question 3:");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion8);
                        mathQuestion8UserAnswer = Console.ReadLine();
                        if (mathQuestion8UserAnswer.ToLower() == mathQuestion8CorrectAnswer.ToLower())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Correct. Last question... :");
                            Console.WriteLine("");
                            Console.WriteLine(trueOrFalse8);
                            trueOrFalse8UserAnswer = Console.ReadLine();
                            if (trueOrFalse8UserAnswer.ToLower() == trueOrFalse8CorrectAnswer.ToLower())
                            {
                                Console.WriteLine("");
                                Console.WriteLine("You've managed to answer all of the questions correctly! You climb the drawbridge up and make a run for it...");
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                if (mathQuestion8UserAnswer.ToLower() != mathQuestion8CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle12UserAnswer.ToLower() != riddle12CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (generalKnowledge8UserAnswer.ToLower() != generalKnowledge8CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (trueOrFalse8UserAnswer.ToLower() != trueOrFalse8CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

            }
            // = = = = = = = = = =  D I C E - R O L L - 5 = = = = = = = = = =
            else if (level3Dice == 5)
            {
                Console.WriteLine(riddle13);
                riddle13UserAnswer = Console.ReadLine();
                if (riddle13UserAnswer.ToLower() == riddle13CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Correct. Question 2:");
                    Console.WriteLine("");
                    Console.WriteLine(generalKnowledge9);
                    generalKnowledge9UserAnswer = Console.ReadLine();
                    if (generalKnowledge9UserAnswer.ToLower() == generalKnowledge9CorrectAnswer.ToLower())
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Correct. Question 3:");
                        Console.WriteLine("");
                        Console.WriteLine(mathQuestion9);
                        mathQuestion9UserAnswer = Console.ReadLine();
                        if (mathQuestion9UserAnswer.ToLower() == mathQuestion9CorrectAnswer.ToLower())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Correct. Last question... :");
                            Console.WriteLine("");
                            Console.WriteLine(trueOrFalse9);
                            trueOrFalse9UserAnswer = Console.ReadLine();
                            if (trueOrFalse9UserAnswer.ToLower() == trueOrFalse9CorrectAnswer.ToLower())
                            {
                                Console.WriteLine("");
                                Console.WriteLine(
                                    "You've managed to answer all of the questions correctly! You climb the drawbridge up and make a run for it...");
                                Console.WriteLine("");
                            }
                        }
                    }

                }

                if (mathQuestion9UserAnswer.ToLower() != mathQuestion9CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(
                        "Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

                if (riddle13UserAnswer.ToLower() != riddle13CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(
                        "Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (generalKnowledge9UserAnswer.ToLower() != generalKnowledge9CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(
                        "Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;
                }

                if (trueOrFalse9UserAnswer.ToLower() != trueOrFalse9CorrectAnswer.ToLower())
                {
                    Console.WriteLine("");
                    Console.WriteLine(
                        "Incorrect, the guards heard you scaling the bridge and threw you back in the cells...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    return;

                }

            }

            Console.ReadLine();
            Console.WriteLine("You manage to get away from the castle. You're sprinting towards the huge forest that surrounds the castle");
            Console.WriteLine("");
            Console.WriteLine("All of a sudden a MASSIVE shadow is cast over you.....");
            Console.WriteLine("");
            Console.ReadLine();

            // = = = = = = = = = H E A D S - O R - T A I L S = = = = = = = = = = 

            Random rd5 = new Random();
            int headOrTailDice = rd5.Next(1, 3);

            string heads = "Heads";
            string tails = "Tails";

            string headsOrTails = "Heads or Tails?";
            string headsOrTailsUserAnswer = "";

            
            // = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

            Console.WriteLine("==============================================================================================================================================");
            Console.WriteLine(@"#  _                   _   _  _             _____ _            ____                              ");
            Console.WriteLine(@"# | |    _____   _____| | | || |           |_   _| |__   ___  |  _ \ _ __ __ _  __ _  ___  _ __  ");
            Console.WriteLine(@"# | |   / _ \ \ / / _ \ | | || |_   _____    | | | '_ \ / _ \ | | | | '__/ _` |/ _` |/ _ \| '_ \ ");
            Console.WriteLine(@"# | |__|  __/\ V /  __/ | |__   _| |_____|   | | | | | |  __/ | |_| | | | (_| | (_| | (_) | | | |");
            Console.WriteLine(@"# |_____\___| \_/ \___|_|    |_|             |_| |_| |_|\___| |____/|_|  \__,_|\__, |\___/|_| |_|");
            Console.WriteLine(@"#                                                                              |___/ ");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Just as you're about to enter the forest a HUGE dragon lands in-front of you...");
            Console.WriteLine("");
            Console.WriteLine(@"#                \||/");
            Console.WriteLine(@"#                |  @___oo");
            Console.WriteLine(@"#      /\  /\   / (__,,,,|");
            Console.WriteLine(@"#     ) /^\) ^\/ _)");
            Console.WriteLine(@"#     )   /^\/   _)");
            Console.WriteLine(@"#     )   _ /  / _)");
            Console.WriteLine(@"# /\  )/\/ ||  | )_)");
            Console.WriteLine(@"#<  >      |(,,) )__)");
            Console.WriteLine(@"# ||      /    \)___)\");
            Console.WriteLine(@"# | \____(      )___) )___");
            Console.WriteLine(@"#  \______(_______;;; __;;;");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("The dragon bends down towards you and opens his mouth displaying his extremely sharp teeth...");
            Console.WriteLine("");
            Console.WriteLine("Just when you think he is going to eat you he asks you a simply question...");
            Console.WriteLine("");
            Console.WriteLine(headsOrTails);

            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)
                heads = "heads";
            else
                heads = "tails";

            headsOrTailsUserAnswer = Console.ReadLine();
            if (headsOrTailsUserAnswer.ToLower() == heads.ToLower())
            {
                Console.WriteLine("");
                Console.WriteLine("The Dragon suddenly jumps off of the ground and flys away... You are free.");
                Console.WriteLine("");
                Console.WriteLine(@"# __   __                                      _      _           _   _   _                                       _ ");
                Console.WriteLine(@"# \ \ / /__  _   _    ___ ___  _ __ ___  _ __ | | ___| |_ ___  __| | | |_| |__   ___    __ _  __ _ _ __ ___   ___| |");
                Console.WriteLine(@"#  \ V / _ \| | | |  / __/ _ \| '_ ` _ \| '_ \| |/ _ \ __/ _ \/ _` | | __| '_ \ / _ \  / _` |/ _` | '_ ` _ \ / _ \ |");
                Console.WriteLine(@"#   | | (_) | |_| | | (_| (_) | | | | | | |_) | |  __/ ||  __/ (_| | | |_| | | |  __/ | (_| | (_| | | | | | |  __/_|");
                Console.WriteLine(@"#   |_|\___/ \__,_|  \___\___/|_| |_| |_| .__/|_|\___|\__\___|\__,_|  \__|_| |_|\___|  \__, |\__,_|_| |_| |_|\___(_)");
                Console.WriteLine(@"#                                       |_|                                            |___/                        ");
                Console.WriteLine("");
                Console.WriteLine("No one cares.");
                Console.ReadLine();
                return;


            }

            if (headsOrTailsUserAnswer.ToLower() == tails.ToLower())
            {
                Console.WriteLine("");
                Console.WriteLine("The Dragon opens his mouth wider and eats you.");
                Console.WriteLine(@"#   ____    _    __  __ _____    _____     _______ ____  ");
                Console.WriteLine(@"#  / ___|  / \  |  \/  | ____|  / _ \ \   / / ____|  _ \ ");
                Console.WriteLine(@"# | |  _  / _ \ | |\/| |  _|   | | | \ \ / /|  _| | |_) |");
                Console.WriteLine(@"# | |_| |/ ___ \| |  | | |___  | |_| |\ V / | |___|  _ < ");
                Console.WriteLine(@"#  \____/_/   \_\_|  |_|_____|  \___/  \_/  |_____|_| \_\");
                Console.WriteLine(@"#                                                        ");
                Console.ReadLine();
                return;

            }







            Console.ReadLine();


        }

    }
}