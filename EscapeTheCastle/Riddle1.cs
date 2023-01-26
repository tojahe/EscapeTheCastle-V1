namespace EscapeTheCastle
{
    public class Riddle1 : Riddle
    {
        public Riddle1() 
            : base("What gets wet when drying?", "towel", 1, _TrueOrFalseQuestion())
        { }

        private static TrueOrFalseQuestion _TrueOrFalseQuestion()
        {
            return new TrueOrFalseQuestion("True or false: A cross between a horse and a zebra is called a 'Hobra'", false);
        }
    }
}
