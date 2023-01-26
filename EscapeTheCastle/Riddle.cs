using System;
using System.Runtime.InteropServices;

namespace EscapeTheCastle
{
    public class Riddle
    {
        public string Question { get; set; }
        public int Level { get; set; }
        public TrueOrFalseQuestion TrueOrFalseQuestion { get; set; }

        private string _Answer;

        public Riddle(string question, string answer, int level, TrueOrFalseQuestion trueOrFalseQuestion)
        {
            Question = question;
            _Answer = answer;
            Level = level;

            TrueOrFalseQuestion = trueOrFalseQuestion;
        }

        public bool GuessRiddle()
        {
            Console.WriteLine(Question);

            string guess = Console.ReadLine();

            int nextLevel = Level++;

            if (_Answer.Trim().ToLower() == guess.Trim().ToLower())
            {
                Console.WriteLine("");
                Console.WriteLine($"Correct. Moving on to level {nextLevel}....");
                Console.ReadLine();

                return true;
            }
            else
            {
                Console.WriteLine("Incorrect, Redeem yourself by answering this question..");
                Console.WriteLine("");
                Console.WriteLine(TrueOrFalseQuestion.Question);
                string rawTrueOrFalse1UserAnswer = Console.ReadLine();

                bool trueOrFalse1UserAnswer;

                bool isBooleanAnswer = bool.TryParse(rawTrueOrFalse1UserAnswer, out trueOrFalse1UserAnswer);

                if (!isBooleanAnswer)
                {
                    Console.WriteLine($"You're a prick, {rawTrueOrFalse1UserAnswer} is clearly not true or false, that's it, I'm not playing anymore!!");

                    throw new Exception("Invalid answer");
                }
                
                if (TrueOrFalseQuestion.CheckAnswer(trueOrFalse1UserAnswer))
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Well done, you can answer an easy question correctly. Time for level {nextLevel}.");
                    Console.ReadLine();
                    return true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Incorrect. Better luck next time.");
                    Console.ReadLine();
                    return false;
                }
            }
        }
    }
}
