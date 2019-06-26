using System;
using System.Collections.Generic;

namespace EsEm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEstudiante> estudiantes = new List<IEstudiante>();

            estudiantes.Add(new Estudiante("Juan", "Perez", 1, "ingenieria civil"));
            estudiantes.Add(new Estudiante("Martin", "Guemes", 2, "ingenieria naval"));
            estudiantes.Add(new EstudianteEmpleado("Jose", "San Martin", 3, "ingenieria de sistemas", "general"));
            estudiantes.Add(new EstudianteEmpleado("Domingo", "Sarmiento", 4, "ciencias sociales", "maestro"));

            Clase clase = new Clase(estudiantes);
            Console.WriteLine(clase.ToString());
        }
    }
}
