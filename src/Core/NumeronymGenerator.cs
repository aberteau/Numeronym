using System.Linq;

namespace Numeronym.Core
{
    public class NumeronymGenerator
    {
        public static string Generate(string toConvert)
        {
            if (string.IsNullOrWhiteSpace(toConvert))
                return null;

            int charCount = toConvert.Length;

            if (charCount <= 3)
                return toConvert;

            char[] charArray = toConvert.ToCharArray();
            char firstChar = charArray.FirstOrDefault();
            char lastChar = charArray.LastOrDefault();

            int omittedCharCount = charCount - 2;
            string numeronym = $"{firstChar}{omittedCharCount}{lastChar}";
            return numeronym;
        }
    }
}
