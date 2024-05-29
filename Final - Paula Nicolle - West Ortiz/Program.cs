using Final___Paula_Nicolle___West_Ortiz;

public class Program
{

    public static void Main(string[] args)
    {
        //Se construyó el menú pirnicpal para el sistema de gestión, se utilizó las clases biblioteca y persona para poner las funciones
        string opcion;
        Biblioteca biblioteca = new Biblioteca();
        Persona persona= new Persona();
        do
        {
        
        Console.WriteLine("");
        Console.WriteLine("Bienvenido al Sistema de Gestión de la Biblioteca");
        Console.WriteLine("Biblioteca: ");
        Console.WriteLine("a) Ingreso de los datos");
        Console.WriteLine("b) Muestra de datos");
        Console.WriteLine("c) Salir");
        Console.WriteLine(" ");
        Console.WriteLine("Ingrese la opcion: ");
        
        opcion = Console.ReadLine() + "";

        switch(opcion)
        {
            //En la primera parte se crea un mini menú en donde pueda ingresar todos los datos y acciones que se le piden al usuario
            case "a":
                do
                {
                Console.WriteLine("1. Ingresar usuario: ");
                Console.WriteLine("2. Prestar libros");
                Console.WriteLine("3. Devolver libros");
                Console.WriteLine("4. Salir");
                opcion = Console.ReadLine();
                switch(opcion)
                {
                case "1":
                    Console.WriteLine("Ingrese los 3 usuarios uno por uno: ");
                    Console.WriteLine(" ");
                    for (int i=0; i< biblioteca.Personas.Length; i++)
                    {
                        biblioteca.Personas[i] = biblioteca.Registro();
                    }
                break;

                case "2":
                    biblioteca.Prestados();
                break;

                case "3":
                    biblioteca.Devolver();
                break;
                case "4":
                break;

                }
                
                }while(opcion != "4");
                break;

            //En esta parte se crea otro mini menú en donde se muestran todos los datos que se ingresaron
            case "b":
                do
                {
                    
                    Console.WriteLine("1. Listado de libros prestados por usuario");
                    Console.WriteLine("2. Consultar cátalogos de libros");
                    Console.WriteLine("3. Listado de usuarios activos");
                    Console.WriteLine("4. Salir");
                    opcion = Console.ReadLine() + "";
                    switch(opcion)
                    {
                        case "1":
                            biblioteca.ImprimirPrestados();
                        break;

                        case "2":
                            biblioteca.Catalogo();
                        break;

                        case "3":
                            biblioteca.Usuarios();
                        break;

                        case "4":
                        break;
                    }
                }while(opcion != "4");
                
                break;

            case "c":
                
                break;

        }
        } while (opcion != "c");
    }
    
}