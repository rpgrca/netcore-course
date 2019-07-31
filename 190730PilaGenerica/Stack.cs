using System;
using System.Collections.Generic;

namespace PilaGenerica
{
    public class Stack<T> {
        private List<T> _List;
        private int _Size;

        public Stack() {
            this._List = new List<T>();
            this._Size = -1;
        }

        public Stack(int size) {
            this._List = new List<T>();
            this._Size = size;
        }

        public T Pop() {
            if (_List.Count > 0) {
                T element = _List[0];
                _List.RemoveAt(0);

                return element;
            }

            throw new IndexOutOfRangeException("Pila vacio");
        }

        public bool Peek() {
            return _List.Count > 0;
        }

        public void Push(T value) {
            if (this._Size < 0 || _List.Count < this._Size) {
                _List.Insert(0, value);
            }
            else {
                throw new StackOverflowException("Pila llena");
            }
        }
    }
}