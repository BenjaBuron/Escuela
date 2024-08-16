using Escuela.Modelos;

namespace Escuela
{
    class Program
    {
        static void Main()
        {
            Administrador admin = new Administrador("juan Perez", 15);

            Modelos.Escuela angelito = new Modelos.Escuela("Escuela Angelito", admin);

            Profesor profe1 = new Profesor("Maria Lopes");
            Materia matematicas = new Materia("Matematicas", 5);
            Materia ciencias = new Materia("ciencias", 4);
            profe1.Añadir(matematicas);
            profe1.Añadir(ciencias);

            Aula aula1 = new Aula("Aula 1", profe1);
            aula1.Añadir(new Estudiante("Ana", 10));
            aula1.Añadir(new Estudiante("Luis", 11));

            Profesor profe2 = new Profesor("Carlos Garcia");
            profe2.Añadir(new Materia("Historia", 4));

            Aula aula2 = new Aula("Aula 2", profe2);
            aula2.Añadir(new Estudiante("Elena", 10));

            angelito.Añadir(aula1);
            angelito.Añadir(aula2);

            angelito.MostrarDetalles();

            Console.WriteLine("\n---------------------------------------------------------------------\n");

            Proyecto proyecto1 = new Proyecto("Proyecto de ciencias", "Investigacion sobre la energia solar");
            Evaluador evaluador1 = new Evaluador("Sofia Alcaraz", "Matematica");
            proyecto1.EvaluarProyecto(evaluador1);

        }
        
    }
}
