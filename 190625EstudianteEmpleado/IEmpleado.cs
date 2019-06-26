using System;

namespace EsEm {
    public interface IEmpleado
    {
        string Ocupacion {
            get;
            set;
        }

        void Trabajar();
    }
}