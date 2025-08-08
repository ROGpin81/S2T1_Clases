
namespace S2T1_Clases
{
    public class Libro
    {
        //Declaración de propiedades/variables
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        //Constructor
        public Libro(string titulo, string autor, int añoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }
        // Método para mostrar información del libro
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año de Publicación: {AñoPublicacion}");
        }
    }
}
