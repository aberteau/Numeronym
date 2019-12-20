using System.Linq;

namespace Numeronym.Core
{
    public class NumeronymGenerator
    {
        public static string Generate(string toConvert)
        {
            if (string.IsNullOrWhiteSpace(toConvert))
                return null;

            char[] charArray = toConvert.ToCharArray();
            char firstChar = charArray.FirstOrDefault();
            char lastChar = charArray.LastOrDefault();

            int numberOfOmittedLetters = toConvert.Length - 2;
            string numeronym = $"{firstChar}{numberOfOmittedLetters}{lastChar}";
            return numeronym;
        }
    }
}
