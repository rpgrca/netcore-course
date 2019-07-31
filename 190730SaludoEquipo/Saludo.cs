using System;

namespace SaludoEquipo {
    public class Saludo {
        private string _Gesto;

        public string Gesto {
            get { return _Gesto; }
        }

        public Saludo(string gesto) {
            this._Gesto = gesto;
        }

        public void Ejecutar() {
            Console.WriteLine(this.Gesto);
        }
    }
}