namespace Examen_Recuperacion_ASA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ListaEnlazada flota = new ListaEnlazada();

Console.WriteLine("1 Agregar Carro");
Console.WriteLine("2 Buscar Carro");
Console.WriteLine("3 Ordenar Carro");


int opciones = 0;

while (opciones == null)
{
    switch (opciones)
    {
        case 0:
            Console.WriteLine($"Agregar Carro");

            break;
        case 1:
            Console.WriteLine("Buscar Carro:");
            break;
        case 2:
            Console.WriteLine("Imprimir:");
            break;
        case 3:
            Console.WriteLine("Ordenar");
            break;
    }

}
/*El usuario tiene que ingresar los datos como año, carro y modelo*/
        }
    }
}
