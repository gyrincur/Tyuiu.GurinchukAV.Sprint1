using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GurinchukAV.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' },
                                       StringSplitOptions.RemoveEmptyEntries);

            var resultWords = words.Select(word =>
                word.Length > 1 ? word.Substring(0, word.Length - 1) : "");

            return string.Join(" ", resultWords.Where(w => !string.IsNullOrEmpty(w)));
        }
    }
}
