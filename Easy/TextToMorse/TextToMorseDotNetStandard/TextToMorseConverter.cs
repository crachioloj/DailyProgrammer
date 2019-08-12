using System;
using System.Collections.Generic;
using System.Text;

namespace TextToMorse
{
    public class TextToMorseConverter
    {
        public static string Convert(string input)
        {
            var morseCode = new StringBuilder();
            foreach (char character in input)
            {
                char characterKey = char.ToLower(character);
                if (MorseCharacters.MorseByCharacter.ContainsKey(characterKey))
                {
                    string morse = MorseCharacters.MorseByCharacter[characterKey];
                    morseCode.Append(morse);
                }
            }

            return morseCode.ToString();
        }
    }
}
;