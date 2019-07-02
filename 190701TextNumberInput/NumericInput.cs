using System;

namespace TextNumericInput {
    public class NumericInput : TextInput {
        public override void Add(char c) {
            int value = (int)c;

            if (Char.IsDigit(c)) {
                _Value += c;
            }
        }
    }
}