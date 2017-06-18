using System;
using System.Security.Principal;
using System.Speech.Synthesis;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            var speaker = new SpeechSynthesizer();
            speaker.Speak($"Hello {WindowsIdentity.GetCurrent().Name}!");
        }
    }
}
