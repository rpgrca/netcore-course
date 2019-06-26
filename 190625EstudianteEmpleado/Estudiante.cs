using System;
using System.Text;

namespace EsEm {
    public class Estudiante : Persona, IEstudiante {
        private string _Carrera;

        public Estudiante(string nombre, string apellido, int id, string carrera) :
            base(nombre, apellido, id) {

            this.Carrera = carrera;
        }

        public string Carrera
        {
            get { return _Carrera; }
            set { _Carrera = value; }
        }

        public void Estudiar() {
            Console.WriteLine("Estudiando...");
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder(base.ToString());
            return stringBuilder.AppendFormat(", estudiante de {0}", this.Carrera).ToString();
        }
    }
}