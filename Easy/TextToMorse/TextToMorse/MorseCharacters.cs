using System;
using System.Collections.Generic;
using System.Text;

namespace TextToMorse
{
    public static class MorseCharacters
    {
        public static readonly string CharA = ".-";
        public static readonly string CharB = "-...";
        public static readonly string CharC = "-.-.";
        public static readonly string CharD = "-..";
        public static readonly string CharE = ".";
        public static readonly string CharF = "..-.";
        public static readonly string CharG = "--.";
        public static readonly string CharH = "....";
        public static readonly string CharI = "..";
        public static readonly string CharJ = ".---";
        public static readonly string CharK = "-.-";
        public static readonly string CharL = ".-..";
        public static readonly string CharM = "--";
        public static readonly string CharN = "-.";
        public static readonly string CharO = "---";
        public static readonly string CharP = ".--.";
        public static readonly string CharQ = "--.-";
        public static readonly string CharR = ".-.";
        public static readonly string CharS = "...";
        public static readonly string CharT = "-";
        public static readonly string CharU = "..-";
        public static readonly string CharV = "...-";
        public static readonly string CharW = ".--";
        public static readonly string CharX = "-..-";
        public static readonly string CharY = "-.--";
        public static readonly string CharZ = "--..";
        
        public static readonly string Char0 = "-----";
        public static readonly string Char1 = ".----";
        public static readonly string Char2 = "..---";
        public static readonly string Char3 = "...--";
        public static readonly string Char4 = "....-";
        public static readonly string Char5 = ".....";
        public static readonly string Char6 = "-....";
        public static readonly string Char7 = "--...";
        public static readonly string Char8 = "---..";
        public static readonly string Char9 = "----.";

        public static readonly Dictionary<char, string> MorseByCharacter =
            new Dictionary<char, string>
            {
                { 'a', CharA },
                { 'b', CharB },
                { 'c', CharC },
                { 'd', CharD },
                { 'e', CharE },
                { 'f', CharF },
                { 'g', CharG },
                { 'h', CharH },
                { 'i', CharI },
                { 'j', CharJ },
                { 'k', CharK },
                { 'l', CharL },
                { 'm', CharM },
                { 'n', CharN },
                { 'o', CharO },
                { 'p', CharP },
                { 'q', CharQ },
                { 'r', CharR },
                { 's', CharS },
                { 't', CharT },
                { 'u', CharU },
                { 'v', CharV },
                { 'w', CharW },
                { 'x', CharX },
                { 'y', CharY },
                { 'z', CharZ },
                { '0', Char0 },
                { '1', Char1 },
                { '2', Char2 },
                { '3', Char3 },
                { '4', Char4 },
                { '5', Char5 },
                { '6', Char6 },
                { '7', Char7 },
                { '8', Char8 },
                { '9', Char9 }
            };
    }
}
