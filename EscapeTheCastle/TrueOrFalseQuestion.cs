namespace EscapeTheCastle
{
    public class TrueOrFalseQuestion
    {
        public string Question { get; set; }

        private bool _Answer;

        public TrueOrFalseQuestion(string question, bool answer)
        {
            Question = question;
            _Answer = answer;
        }

        public bool CheckAnswer(bool guess)
        {
            return _Answer == guess;
        }
    }
}
