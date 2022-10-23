using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringChallenge("fun&!! time"));
        }
        public static string StringChallenge(string sen)
        {

            if (string.IsNullOrEmpty(sen))
                return null;
            //
            //Remove special characters from string
            //
            sen = RemoveSpecialCharacters(sen);


            //determine the biggest word in the string
            var word = string.Empty;
            var words = sen.Split(" ");
            var length = 0;

            foreach (var w in words)
            {
                if (w.Length > length)
                {
                    word = w;
                    length = w.Length;
                }
            }

            var stringToConcat = "u2h5krgyb9";
            var concatString = string.Concat(word, stringToConcat);

            // Replace every third character in the string with X
            var replacedConcatString = ReplaceThirdCharacterWithX(concatString);


            return replacedConcatString;

        }

        private static string ReplaceThirdCharacterWithX(string concatString)
        {
            var str = concatString.ToCharArray();
            var nth = 3; // the nth character you want to replace
            var replaceWith = 'X'; // the character you want to replace the nth value
            for (var i = nth - 1; i < str.Length - 1; i += nth)
            {
                str[i] = replaceWith;
            }
            string charsStr = new string(str);
            return charsStr;
        }

        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
