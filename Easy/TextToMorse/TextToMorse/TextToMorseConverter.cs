using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToMorse
{
    public class TextToMorseConverter 
    {
        public static string Convert0(string input)
        {
            var code = new StringBuilder();

            foreach (var character in input)
            {
                var morse = MorseCharacters.MorseByCharacter[char.ToLower(character)];
                code.Append(morse);
            }

            return code.ToString();
        }

        public static string Convert1(string input)
        {
            return input.
                   Select(i => MorseCharacters.MorseByCharacter[char.ToLower(i)]).
                   Aggregate(string.Empty, (word, character) => word + character);
        }

        public static IEnumerable<string> Convert(IEnumerable<string> inputList)
        {
            var morseCodeList = new List<string>();

            //var result = Parallel.ForEach(inputList, (c) => Convert(c));
            return morseCodeList;
        }
    }
}