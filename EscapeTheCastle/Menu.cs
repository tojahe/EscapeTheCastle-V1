using System;

namespace EscapeTheCastle
{
    public static class Menu
    {
        public static void Welcome()
        {
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
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("     Below are examples of the questions you are going to be asked and how to answer them:");
            Console.WriteLine("");
            Console.WriteLine("     Riddles- answer with a one word answer");
            Console.WriteLine("     Question: I am always hungry and will die if not fed, but whatever I touch will soon turn red. What am I?");
            Console.WriteLine("     Answer: Fire");
            Console.WriteLine("");
            Console.WriteLine("     General Knowledge- answer with a one word answer");
            Console.WriteLine("     Question: Which is faster, light or sound?");
            Console.WriteLine("     Answer:Light");
            Console.WriteLine("");
            Console.WriteLine("     Math- answer with 1 number");
            Console.WriteLine("     Question: What is the only even prime number?");
            Console.WriteLine("     Answer: 2");
            Console.WriteLine("");
            Console.WriteLine("     True or false - answer with either true or false");
            Console.WriteLine("     Question: Female cows produce milk");
            Console.WriteLine("     Answer:  true");
            Console.WriteLine("");
            Console.WriteLine("     Press enter to continue...");
            Console.ReadLine();
        }
    }
}
