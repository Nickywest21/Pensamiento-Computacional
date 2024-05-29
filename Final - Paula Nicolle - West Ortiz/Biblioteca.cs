using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace Final___Paula_Nicolle___West_Ortiz;

public class Biblioteca
{
        //Se inicializaron los arreglos y se disposieron la cantidad total que puede recibir.
        public Libro [] Libros = new Libro [5];
        public Persona [] Personas = new Persona [3];
        public string [] PrestadosPersona = new string [3];
    public Biblioteca()
    {
        //Se le brindo un número exacto a cada libro que proviene de la clase libro.
        Libros[0] = new Libro ("El Dador");
        Libros[1] = new Libro("El Señor de las Moscas");
        Libros[2] = new Libro("Viaje al Centro de la Tierra");
        Libros[3] = new Libro("El Diario de Anna Frank");
        Libros[4] = new Libro("Orgullo y Prejuicio");
    }


    public Persona Registro()
    {
        //Se inicializan algunas variables y se piden los datos que se le asignan a persona.
        string tel;
        string carne;

        Persona personita = new Persona ();
        Console.WriteLine ("Ingrese su nombre: ");
        personita.NombrePersona = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine ("Ingrese sus apellidos: ");
        personita.Apellidos = Console.ReadLine();
        Console.WriteLine(" ");

        
        do
        {
        Console.WriteLine("Ingrese su carnet: ");
        personita.Carnet = Console.ReadLine();
        carne = personita.Carnet;
        if (carne.Length == 7)
        {
            Console.WriteLine("Su dato es válido, puede seguir.");
        }
        else
        {
            Console.WriteLine("Su dato no es válido, debe volver a ingresar su Carnet.");
        }
        }while(carne.Length != 7);

        
        Console.WriteLine("");
        do
        {
        Console.WriteLine("Ingrese su número de teléfono: ");
        personita.Telefono = Console.ReadLine();
        tel = personita.Telefono;
        if (tel.Length == 8)
        {
            Console.WriteLine("El dato ingresado es válido, puede seguir");
        }
        else
        {
            Console.WriteLine("Su dato ingresado no es válido, debe volver a ingresar su Teléfono");
        }
        }while(tel.Length !=8);

    return personita;

    }

    //Se imprime los titulos de los libros
    public void Catalogo()
    {
        Console.WriteLine("");
        for (int i = 0; i < Libros.Length; i++)
        {
        Console.WriteLine((i+1) + "." + " " + Libros[i].Titulo);
        }
    Console.WriteLine("");
    }


    // Por medio de for e if se encontraron el libro que desea prestar y a la persona que se desea a prestar
    public void Prestados()
    {


        Console.WriteLine (" ");
        Console.WriteLine("Ingrese el número del libro que desea ingresar: ");
        for (int i = 0; i< Libros.Length; i++)
        {
            Console.WriteLine((i+1) + "." + " " + Libros[i].Titulo);
        }
        int indice = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("");
        Libro libroPrestado = Libros[indice];
        if(libroPrestado.usuario != null)
        {
            Console.WriteLine($"El libro que quiere está prestado por: {libroPrestado.usuario.NombrePersona}");
        }
        else
        {
            Console.WriteLine("");
            
            Console.WriteLine("A qué persona se lo desea prestar: ");
            for (int i = 0; i< Personas.Length; i++)
            {
                Console.WriteLine((i+1) + "." + " " + Personas[i].NombrePersona);
            }
            int indiceP = int.Parse(Console.ReadLine()) - 1;
            libroPrestado.usuario = Personas[indiceP];
        }
        Console.WriteLine(" ");
   
    }

    //Se imprimé todos los datos del usuario con respecto al libro que se le asignó.
    public void ImprimirPrestados()
    {

        for (int i = 0; i < Libros.Length; i++)
        {
        Libro libroprestado = Libros[i];
        if (libroprestado.usuario != null)
        {
            Console.WriteLine($"{libroprestado.usuario.NombrePersona} {libroprestado.usuario.Apellidos}, con un número de Carnet de: {libroprestado.usuario.Carnet} y telefono: {libroprestado.usuario.Telefono}; reservó el libro: {libroprestado.Titulo}");
        }
        }
        Console.WriteLine(" ");
    }

    //De una manera parecida en la que se presto el libro se puede devolver recorriendo un for y verificando si el libro se dio o se puede devolver
    public void Devolver()
    {
        Console.WriteLine (" ");
        Console.WriteLine("Ingrese el número del libro que desea devolver: ");
        for (int i = 0; i< Libros.Length; i++)
        {
            Console.WriteLine((i+1) + "." + " " + Libros[i].Titulo);
        }
        int indice = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine("");
        Libro libroPrestado = Libros[indice];
        if(libroPrestado.usuario == null)
        {
            Console.WriteLine($"El libro que quiere devolver no esta prestado");
        }
        else
        {
            libroPrestado.usuario = null; 
            Console.WriteLine("El libro se ha devuelto exitosamente");
        }

    }

    //Se utilizó la misma logica que en ImprimirPrestados, sin embargo solo se imprime el nombre la persona que prestó
    public void Usuarios()
    {
        for (int i = 0; i < Libros.Length; i++)
        {
        Libro libroprestado = Libros[i];
        if (libroprestado.usuario != null)
        {
            Console.WriteLine($"El usuario activo que pidio un libro es: {libroprestado.usuario.NombrePersona}");
        }
        }
        Console.WriteLine(" ");
    }

}
