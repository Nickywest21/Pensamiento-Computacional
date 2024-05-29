using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Final___Paula_Nicolle___West_Ortiz;

public class Libro
{
    public string Titulo;

    //Asigno persona porque el libro solo puede ser prestado una vez
    public Persona usuario; 

    //Inicialización del método constructor
    public Libro(string t)
    {
        Titulo = t;
    }
}
