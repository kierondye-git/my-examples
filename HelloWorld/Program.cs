using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = GetStrategy(GetStrategyId(args.FirstOrDefault()));
            strategy.Output("Hello World!");
        }

        private static IOutputStrategy GetStrategy(string strategyId)
        {
            IOutputStrategy strategy;
            switch (strategyId)
            {
                case SpeechStrategy.StrategyId:
                    strategy = new SpeechStrategy();
                    break;
                default:
                    strategy = new ConsoleStrategy();
                    break;
            }
            return strategy;
        }

        private static string GetStrategyId(string strategyId)
        {
            if (strategyId != null) return strategyId;

            Console.WriteLine("Please enter a strategy or leave blank for default:");
            return Console.ReadLine();
        }
    }
}
