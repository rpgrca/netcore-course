using System;
using System.Linq;
using System.Collections.Generic;

namespace Lottery {
    public class Player {
        public List<int>Bet { get; private set; }
        public string Name { get; private set; }

        public Player(string name, int bet) {
            this.Name = name;
            this.Bet = new List<int>() { bet };
        }

        public Player(string name, int values, int minValue, int maxValue) {
            Random rand = new Random();

            this.Name = name;
            this.Bet = Utilities.CreateBet(values, minValue, maxValue);
        }

        public void PlayerEventHandler(object sender, EventArgs e) {
            DrawnNumberEventArgs eventArgs = e as DrawnNumberEventArgs;
            if (eventArgs != null) {
                Console.Write($"Soy {this.Name}, aposté a {this.Bet.PrintValues()} y ");

                if (this.Bet.Intersect(eventArgs.DrawnNumbers).Count() == this.Bet.Count)
                    Console.WriteLine("gané!");
                else
                    Console.WriteLine("perdí!");
            }
        }
    }
}
