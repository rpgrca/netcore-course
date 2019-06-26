using System;

namespace EsEm {
    public interface IEstudiante
    {
        string Carrera {
            get;
            set;
        }

        void Estudiar();
    }
}