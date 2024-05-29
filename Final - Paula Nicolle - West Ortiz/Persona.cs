using System.Diagnostics.Contracts;

namespace Final___Paula_Nicolle___West_Ortiz;

public class Persona
{
    //En esta parte del código se inicializaron todas las varibales que necesitaron para crear al usuario
    public string NombrePersona;
    public string Apellidos;
    public string Carnet;
    public string Telefono;

    public Persona(){
        NombrePersona = "";
        Apellidos = "";
        Carnet = "";
        Telefono = "";
    }
}
