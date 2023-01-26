using System;

namespace EscapeTheCastle
{
    public class Dice
    {
        private Random _RandomDiceRoll = new Random();
        private int _DiceRoll;

        public int RollDice()
        {
            _DiceRoll = _RandomDiceRoll.Next(1, 5);

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
            Console.WriteLine("and roll a..." + _DiceRoll + "...");
            Console.WriteLine("");
            Console.WriteLine("Answer this riddle to continue...");
            Console.WriteLine("");

            return _DiceRoll;
        }
    }
}
