using System;
using System.Text;

namespace EsEm {
    public class Empleado : Persona, IEmpleado {
        private string _Ocupacion;

        public Empleado(string nombre, string apellido, int id, string ocupacion) :
            base (nombre, apellido, id) {

            this.Ocupacion = ocupacion;
        }

        public string Ocupacion
        {
            get { return _Ocupacion; }
            set { _Ocupacion = value; }
        }

        public void Trabajar() {
            Console.WriteLine("Trabajando...");
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder(base.ToString());
            return stringBuilder.AppendFormat(", trabaja como {0}", this.Ocupacion).ToString();
        }
    }
}