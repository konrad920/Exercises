namespace Exercises
{
    public class Pangram
    {
        public bool IsPangram(string sentence)
        {
            var normalizeSentence = sentence.ToLower();
            var letters = normalizeSentence.Distinct().ToList();
            var answer = letters.Where(x => x != ' ');
            if (answer.Count() == 26)
            {
                return true;
            }
            return false;
        }
    }
}
