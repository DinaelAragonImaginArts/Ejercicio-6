internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        cliente.edad = 16;
        cliente.nombre = "Dinael";
        cliente.telefono = "123-456-7891";
        cliente.credito = "Bancario";

        Console.WriteLine("El cliente " + cliente.nombre + " Con el numero de telefono " + cliente.telefono + " de edad " + cliente.edad + " años " + " tiene un credito de tipo " + cliente.credito);

    }

}

public class Persona
{
    public int edad;
    public string nombre;
    public string telefono;

}

public class Cliente : Persona
{
    public string credito;

}
