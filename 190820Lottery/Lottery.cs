using System;

namespace Lottery {
    public class DrawnNumberEventArgs : EventArgs {
        public int DrawnNumber { get; private set; }
        
        public DrawnNumberEventArgs(int value) {
            this.DrawnNumber = value;
        }
    }

    public class Lottery {
        public event EventHandler<DrawnNumberEventArgs> DrawNumberEventHandler;
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int Values { get; private set; }

        public Lottery(int values, int minValue, int maxValue) {
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Values = Values;
        }

        public void AddPlayer(Player player) {
            this.DrawNumberEventHandler += player.PlayerEventHandler;
        }

        public void Draw() {
            int value = new Random().Next(this.MinValue, this.MaxValue);
            Console.WriteLine($"Soy la loteria y elegí el número {value}.");
            this.DrawNumberEventHandler(this, new DrawnNumberEventArgs(value));
        }
    }
}