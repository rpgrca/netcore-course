using System;
using System.Text;

namespace EsEm {
    public class Persona {
        private string _Nombre;
        private string _Apellido;
        private int _ID;

        public Persona(string nombre, string apellido, int id) {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.ID = id;
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder();
            return stringBuilder.AppendFormat("{0} {1}", this.Nombre, this.Apellido).ToString();
        }      
    }
}