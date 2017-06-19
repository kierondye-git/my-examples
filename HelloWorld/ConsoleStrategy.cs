using System;

namespace HelloWorld
{
    internal class ConsoleStrategy : IOutputStrategy
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}