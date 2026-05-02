using Dsw2026Ej8.Problema_N_1;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductHelper helper = new ProductHelper();

            long codigo = 1024;
            string descripcion = "Monitor Gamer 24 Pulgadas";
            decimal precio = 350500.99m;

            string etiqueta = helper.ObtenerEtiquetaProducto(codigo, descripcion, precio);

            Console.WriteLine("Etiqueta generada:");
            Console.WriteLine(etiqueta);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
