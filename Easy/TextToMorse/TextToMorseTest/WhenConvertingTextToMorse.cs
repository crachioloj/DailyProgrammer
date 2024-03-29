using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextToMorse;

namespace TextToMorseConverterTest
{
    [TestClass]
    public class WhenConvertingTextToMorse
    {
        [TestMethod]
        [DataRow("sos", "...---...")]
        [DataRow("daily", "-...-...-..-.--")]
        [DataRow("programmer", ".--..-.-----..-..-----..-.")]
        [DataRow("bits", "-.....-...")]
        [DataRow("three", "-.....-...")]
        public void AndValidInputProvidedThenValidMorseReturned(string text, string morseCode)
        {
            string result = TextToMorseConverter.Convert(text);
            Assert.AreEqual(result, morseCode);
        }
    }
}
