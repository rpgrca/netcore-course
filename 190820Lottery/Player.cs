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
            this.Bet = new List<int>();

            for (int index = 0; index < values; index++) {
                this.Bet.Add(rand.Next(minValue, maxValue));
            }
        }

        public void PlayerEventHandler(object sender, EventArgs e) {
            DrawnNumberEventArgs eventArgs = e as DrawnNumberEventArgs;
            if (eventArgs != null) {
                if (this.Bet.Contains(eventArgs.DrawnNumber)) {
                    this.Bet.Remove(eventArgs.DrawnNumber);
                    this.Bet.Add(-eventArgs.DrawnNumber);
                }

                Console.Write($"Soy {this.Name}, aposté a ");
                foreach (int value in this.Bet) {
                    Console.Write($"{value}, ");
                }

                if (this.Bet.Find(p => p > 0) == 0) {
                    Console.WriteLine(" gané!");
                }
                else {
                    Console.WriteLine(" perdí!");
                }
            }
        }
    }
}
