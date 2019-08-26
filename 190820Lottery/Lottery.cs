using System;
using System.Collections.Generic;

namespace Lottery {
    public class DrawnNumberEventArgs : EventArgs {
        public List<int> DrawnNumbers { get; private set; }
        
        public DrawnNumberEventArgs(List<int> values) {
            this.DrawnNumbers = values;
        }
    }

    public class Lottery {
        public event EventHandler<DrawnNumberEventArgs> DrawNumberEventHandler;
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int Values { get; private set; }

        public Lottery(int values, int minValue, int maxValue) {
            if (minValue > maxValue)
                throw new ArgumentException("Valor mínimo no puede ser mayor al valor máximo.");

            if (minValue < 1 || maxValue < 1)
                throw new ArgumentException("El rango válido no puede incluir números negativos.");

            if (values > (maxValue - minValue))
                throw new ArgumentException("El rango es menor a la cantidad de números a escoger por sorteo.");

            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Values = values;
        }

        public void AddPlayer(Player player) {
            this.DrawNumberEventHandler += player.PlayerEventHandler;
        }

        public void Draw() {
            List<int> values = Utilities.CreateBet(this.Values, this.MinValue, this.MaxValue);

            if (this.Values == 1) {
                Console.WriteLine($"Soy la lotería y elegí el número {values[0]}.");
            }
            else {
                Console.WriteLine($"Soy la lotería y elegí los números {values.PrintValues()}.");
            }

            this.DrawNumberEventHandler(this, new DrawnNumberEventArgs(values));
        }
    }
}