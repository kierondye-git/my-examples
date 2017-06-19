using System;
using System.Speech.Synthesis;

namespace HelloWorld
{
    internal class SpeechStrategy : IOutputStrategy
    {
        public const string StrategyId = "speech";

        public void Output(string message)
        {
            var speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(message);
        }
    }
}