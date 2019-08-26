using System;
using System.Collections.Generic;

namespace Lottery {
    public static class Utilities {
        public static string PrintValues(this List<int> values) {
            string result = String.Empty;

            foreach (int value in values) {
                if (result == String.Empty) {
                    result = value.ToString();
                }
                else {
                    result = String.Format("{0}, {1}", result, value);
                }
            }

            return result;
        }

        public static List<int> CreateBet(int count, int min, int max) {
            List<int> values = new List<int>();
            int chosen;
            Random rand = new Random();

            // Choose x random numbers
            for (int total = 0; total < count; total++)  {
                do {
                    chosen = rand.Next(min, max);
                } while (values.Contains(chosen));

                values.Add(chosen);
            }

            return values;
        }
    }
}