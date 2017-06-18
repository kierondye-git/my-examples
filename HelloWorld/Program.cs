using System;
using System.Speech.Synthesis;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            var speaker = new SpeechSynthesizer();
            speaker.Speak("Hello World!");
        }
    }
}
