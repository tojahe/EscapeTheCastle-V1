namespace EscapeTheCastle
{
    public class Riddle3 : Riddle
    {
        public Riddle3()
            : base("Where can you find cities, towns, and streets but no people?", "map", 1, _TrueOrFalseQuestion())
        {
        }

        private static TrueOrFalseQuestion _TrueOrFalseQuestion()
        {
            return new TrueOrFalseQuestion("True or false: Fish cannot blink", true);
        }
    }
}