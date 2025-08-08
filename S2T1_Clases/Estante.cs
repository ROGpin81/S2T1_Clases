
namespace S2T1_Clases
{
    public class Estante
    {
        // Declaración de propiedades/variables
        public int NumeroEstante { get; set; }
        public int CapacidadMaxima { get; set; }
        public List<Libro> LibrosEnEstante { get; set; }

        // Constructor
        public Estante(int numeroEstante, int capacidadMaxima)
        {
            NumeroEstante = numeroEstante;
            CapacidadMaxima = capacidadMaxima;
            LibrosEnEstante = new List<Libro>();
        }
        // Método para agregar un libro al estante
        public void MostrarInformacion()
        {
            Console.WriteLine($"Estante Número: {NumeroEstante}");
            Console.WriteLine($"Capacidad Máxima: {CapacidadMaxima}");
            Console.WriteLine("Libros en el estante:");
            foreach (var libro in LibrosEnEstante)
            {
                libro.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
