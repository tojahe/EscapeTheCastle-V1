namespace EscapeTheCastle
{
    public class Riddle4 : Riddle
    {
        public Riddle4()
            : base("It’s been around for millions of years, but is never more than a month old. What is it?", "moon", 1, _TrueOrFalseQuestion())
        {
        }

        private static TrueOrFalseQuestion _TrueOrFalseQuestion()
        {
            return new TrueOrFalseQuestion("True or false: Coffee is made from berries", true);
        }
    }
}