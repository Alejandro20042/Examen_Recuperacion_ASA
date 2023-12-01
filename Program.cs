namespace Examen_Recuperacion_ASA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ListaEnlazada flota = new ListaEnlazada();
            flota.AgregarCarro(new Carros(123,"Toyota",2023));
            flota.AgregarCarro(new Carros(223, "Silverado", 2022));
            flota.AgregarCarro(new Carros(412, "Ram", 2026));
            flota.AgregarCarro(new Carros(764, "Chevrolet", 2018));
            flota.AgregarCarro(new Carros(669, "Munstang", 2025));

            
            flota.ImprimirPorAño();

            flota.OrdenarPorAño();

            Console.WriteLine($"Se encontro el Carro{flota.BuscarCarro("Toyota")}");
            flota.BuscarCarro("Toyota");
        }
    }
}
