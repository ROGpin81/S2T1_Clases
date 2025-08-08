
using S2T1_Clases;
//Instanciar al menos tres objetos de tipo libro
Libro libro1 = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967);
Libro libro2 = new Libro("1984", "George Orwell", 1949);
Libro libro3 = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943);

//Crear dos objetos de tipo persona
Persona persona1 = new Persona("Juan", "Pérez", 30);
Persona persona2 = new Persona("Ana", "Gómez", 25);

//Crear un objeto de tipo estante y agregarle los libros
Estante estante1 = new Estante(1, 5);
estante1.LibrosEnEstante.Add(libro1);
estante1.LibrosEnEstante.Add(libro2);
estante1.LibrosEnEstante.Add(libro3);

//Mostrar la información de los libros
Console.WriteLine("Información de los libros:");
libro1.MostrarInformacion();
Console.WriteLine();
libro2.MostrarInformacion();
Console.WriteLine();    
libro3.MostrarInformacion();

Console.WriteLine();
Console.WriteLine("Contenido del estante:");
estante1.MostrarInformacion();

Console.WriteLine();
Console.WriteLine("Saludos de las personas:");
persona1.Saludar();
persona2.Saludar();




