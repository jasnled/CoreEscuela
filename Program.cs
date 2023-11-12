// See https://aka.ms/new-console-template for more information
using CoreEscuela.Entidades;
namespace CoreEscuela
{
    class Program
    {
        private static void Main(string[] args)
        {
            string message;
            var escuela = new Escuela("Republica de Haití", 1923, TiposEscuela.Primaria, ciudad: "San Jose");

            message = escuela.Name + " ubicada en " + escuela.Ciudad;
            Console.WriteLine(message);

            escuela.Cursos = new Curso[]{
                new Curso("101", TiposJornada.Mañana),
                new Curso("201", TiposJornada.Tarde),
                new Curso("301", TiposJornada.Noche)
            };
          
            ImprimirCursos(escuela);
        }
        public static void ImprimirCursos(Escuela escuela){
            Console.WriteLine("==========================");
            Console.WriteLine(escuela);
            Console.WriteLine("==========================");
            foreach (Curso cur in escuela.Cursos){
                Console.WriteLine(cur);
             }
        }
    }
}