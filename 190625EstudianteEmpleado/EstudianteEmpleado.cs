using System;
using System.Text;

namespace EsEm {
    public class EstudianteEmpleado : Persona, IEstudiante, IEmpleado {
        private Estudiante _Estudiante;
        private Empleado _Empleado;

        public EstudianteEmpleado(string nombre, string apellido, int id, string carrera, string ocupacion) :
            base(nombre, apellido, id) {
                _Estudiante = new Estudiante(nombre, apellido, id, carrera);
                _Empleado = new Empleado(nombre, apellido, id, ocupacion);
        }

        public string Ocupacion
        {
            get {
                return _Empleado.Ocupacion;
            }
            set {
                _Empleado.Ocupacion = value;
            }
        }

        public string Carrera {
            get {
                return _Estudiante.Carrera;
            }
            set {
                _Estudiante.Carrera = value;
            }
        }

        public void Trabajar() {
            _Empleado.Trabajar();
        }

        public void Estudiar() {
            _Estudiante.Estudiar();
        }

        public override string ToString() {
            StringBuilder stringBuilder = new StringBuilder(base.ToString());
            return stringBuilder.AppendFormat(", estudiante de {0}, trabaja como {1}", this.Carrera, this.Ocupacion).ToString();
        }
    }
}