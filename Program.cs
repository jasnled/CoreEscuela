// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
namespace CoreEscuela {

    class Program
    {
        private static void Main(string[] args)
        {
            string message; 
            var escuela = new Escuela("Republica de Haití", 1923, TiposEscuela.Primaria, ciudad: "San Jose");
         
            message = escuela.Name+" ubicada en "+escuela.Ciudad;
            Console.WriteLine(message);
            
            Curso[] cursos = new Curso[3]; 
            Curso curso1 = new Curso("101", TiposJornada.Mañana);
            Curso curso2 = new Curso("201", TiposJornada.Tarde);
            Curso curso3 = new Curso("301", TiposJornada.Noche);
            cursos[0] = curso1;
            cursos[1] = curso2;
            cursos[2] = curso3;
            Console.WriteLine(escuela);
            Console.WriteLine("==========================");
            
            foreach (Curso cur in cursos){
                Console.WriteLine(cur);
            }
        }
    }
} 