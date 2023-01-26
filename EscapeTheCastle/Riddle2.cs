using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheCastle
{
    public class Riddle2 : Riddle
    {
        public Riddle2() 
            : base("What goes all the way around the world but stays in a corner?", "stamp", 1, _TrueOrFalseQuestion())
        {
        }

        private static TrueOrFalseQuestion _TrueOrFalseQuestion()
        {
            return new TrueOrFalseQuestion("True or false: Hot and cold water sound the same when poured", false);
        }
    }
}
