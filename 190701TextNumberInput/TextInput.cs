using System;

namespace TextNumericInput
{
    public class TextInput
    {
        protected string _Value;

        public TextInput() {
            _Value = String.Empty;
        }

        public virtual void Add(char c) {
            _Value += c;
        }

        public string GetValue() {
            return _Value;
        }
    }
}
