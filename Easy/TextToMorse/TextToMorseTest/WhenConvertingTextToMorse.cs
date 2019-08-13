using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TextToMorse;

namespace TextToMorseConverterTest
{
    [TestClass]
    public class WhenConvertingTextToMorse
    {
        private Stopwatch stopwatch;

        [TestInitialize]
        public void Initialize()
        {
            stopwatch = new Stopwatch();
        }

        [TestMethod]
        [DataRow("sos", "...---...", 0)]
        [DataRow("sos", "...---...", 1)]
        [DataRow("daily", "-...-...-..-.--", 0)]
        [DataRow("daily", "-...-...-..-.--", 1)]
        [DataRow("programmer", ".--..-.-----..-..-----..-.", 0)]
        [DataRow("programmer", ".--..-.-----..-..-----..-.", 1)]
        [DataRow("bits", "-.....-...", 0)]
        [DataRow("bits", "-.....-...", 1)]
        [DataRow("three", "-.....-...", 0)]
        [DataRow("three", "-.....-...", 1)]
        public void AndValidInputProvidedThenValidMorseReturned(string text, string morseCode, int convertVersion)
        {
            stopwatch.Reset();
            stopwatch.Start();
            string result;
            switch (convertVersion)
            {
                case 1:
                    result = TextToMorseConverter.Convert1(text);
                    break;
                case 0:
                default:
                    result = TextToMorseConverter.Convert0(text);
                    break;
            }

            stopwatch.Stop();
            Debug.WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds} ms");
            Assert.AreEqual(result, morseCode, $"Runtime: {stopwatch.ElapsedMilliseconds} ms");
        }

        [TestMethod]
        public void AndValidInputListProvidedThenValidListOfMorseReturned()
        {
            string[] lines = System.IO.File.ReadAllLines("WordList.txt");
            var result = TextToMorseConverter.Convert(lines);
        }
    }
}
