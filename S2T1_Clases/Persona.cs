

namespace S2T1_Clases
{
    public class Persona
    {
        //Declaración de propiedades/variables
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        //Constructor
        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        // Método para mostrar información de la persona
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido} y tengo {Edad} años.");
        }
    }
}
