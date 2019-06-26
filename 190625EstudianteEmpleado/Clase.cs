using System;
using System.Collections.Generic;

namespace EsEm {
    public class Clase {
        private List<IEstudiante> _Estudiantes;

        public Clase(List<IEstudiante> estudiantes) {
            _Estudiantes = estudiantes;
        }

        public override string ToString() {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            stringBuilder.AppendLine("Tomando lista...");
            foreach (IEstudiante estudiante in _Estudiantes) {
                stringBuilder.AppendLine(estudiante.ToString());
            }

            stringBuilder.AppendLine("Gracias por venir.");
            return stringBuilder.ToString();
        }
    }
}