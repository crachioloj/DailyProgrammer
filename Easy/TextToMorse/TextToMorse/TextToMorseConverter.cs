using System;
using System.Collections.Generic;
using System.Text;

namespace TextToMorse
{
    public class TextToMorseConverter
    {
        public static string Convert(string input)
        {
            var code = new StringBuilder();
            foreach (var character in input)
            {
                var morse = MorseCharacters.MorseByCharacter[char.ToLower(character)];
                code.Append(morse);
            }

            return code.ToString();
        }
    }
}
;