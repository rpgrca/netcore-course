using System;

namespace SaludoEquipo {
    public abstract class Player {
        private string _Apellido;
        private string _Nombre;
        private Saludo _Saludo;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        
        public string Nombre {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public Saludo Saludo {
            get { return _Saludo; }
            set { _Saludo = value; }
        }

        public Player(string nombre, string apellido, Saludo saludo) {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Saludo = saludo;
        }

        public void Saludar() {
            Console.WriteLine(String.Format("{0} {1} {2}.", this.Nombre, this.Apellido, this.Saludo.Gesto));
        }
    }
}