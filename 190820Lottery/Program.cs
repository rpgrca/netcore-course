using System;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottery lottery = new Lottery(1, 1, 20);
            Random rand = new Random();

            lottery.AddPlayer(new Player("Juan", lottery.Values, lottery.MinValue, lottery.MaxValue));
            lottery.AddPlayer(new Player("Nancy", lottery.Values, lottery.MinValue, lottery.MaxValue));
            lottery.AddPlayer(new Player("Martin", lottery.Values, lottery.MinValue, lottery.MaxValue));

            lottery.Draw();
        }
    }
}
