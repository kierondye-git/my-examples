using System;
using System.Speech.Synthesis;

namespace HelloWorld
{
    public static class Messenger
    {
        public static void Message(this string message)
        {
            ConsoleMessage(message);
            SpeechMessage(message);
        }

        private static void SpeechMessage(string message)
        {
            var speaker = new SpeechSynthesizer();
            speaker.Speak(message);
        }

        private static void ConsoleMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}