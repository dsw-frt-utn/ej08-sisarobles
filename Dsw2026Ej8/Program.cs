using Dsw2026Ej8.Problema_N_1;
using Dsw2026Ej8.Problema_N_2;
using Dsw2026Ej8.Problema_N_3;

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

            Class1 p2 = new Class1();
            string resultado = p2.CrearResumenVenta(505, "Teclado Mecánico", 2, 50000m);
            Console.WriteLine(resultado);

            Console.WriteLine("\n--- Resultado Problema 3 ---");

            Problema3 p3 = new Problema3();
            Product miProducto = new Product();

            int miNumero = 100;

            miProducto.SetDescription("Descripción Original");

            string resultadoP3 = p3.CompararCopias(miNumero, miProducto);

            Console.WriteLine(resultadoP3);

            Console.WriteLine($"\nComprobación en Main:");
            Console.WriteLine($"Número original en Main: {miNumero} (No cambió)");
            Console.WriteLine($"Descripción en Main: {miProducto.GetDescription()} (¡Sí cambió!)");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
