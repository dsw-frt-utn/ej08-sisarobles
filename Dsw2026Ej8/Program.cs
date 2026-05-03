using Dsw2026Ej8.Problema_N_1;
using Dsw2026Ej8.Problema_N_2;
using Dsw2026Ej8.Problema_N_3;
using Dsw2026Ej8.Problema_N_4;
using Dsw2026Ej8.Problema_N_5;
using Dsw2026Ej8.Problema_N_6;

namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA 1
            Console.WriteLine("=== PROBLEMA 1 ===");
            ProductHelper helper = new ProductHelper();

            long codigo = 1024;
            string descripcion = "Monitor Gamer 24 Pulgadas";
            decimal precio = 350500.99m;

            string etiqueta = helper.ObtenerEtiquetaProducto(codigo, descripcion, precio);

            Console.WriteLine("Etiqueta generada:");
            Console.WriteLine(etiqueta);

            //PROBLEMA 2
            Console.WriteLine("\n=== PROBLEMA 2 ===");
            Class1 p2 = new Class1();
            string resultado = p2.CrearResumenVenta(505, "Teclado Mecánico", 2, 50000m);
            Console.WriteLine(resultado);

            //PROBLEMA 3
            Console.WriteLine("\n=== PROBLEMA 3 ===");
            Problema3 p3 = new Problema3();
            Product miProducto = new Product();

            int miNumero = 100;
            miProducto.SetDescription("Descripción Original");
            string resultadoP3 = p3.CompararCopias(miNumero, miProducto);

            Console.WriteLine(resultadoP3);
            Console.WriteLine($"Comprobación:");
            Console.WriteLine($"Número original: {miNumero} (No cambió)");
            Console.WriteLine($"Descripción: {miProducto.GetDescription()} (Sí cambió)");

            //PROBLEMA 4
            Console.WriteLine("\n=== PROBLEMA 4 ===");
            Problema4 p4 = new Problema4();

            double promedio = p4.CalcularPromedio(8, 15, null);

            Console.WriteLine($"Promedio Final: {promedio}");

            //PROBLEMA 5
            Console.WriteLine("\n=== PROBLEMA 5 ===");
            Problema5 p5 = new Problema5();

            Sale ventaMinorista = new RetailSale();
            ventaMinorista.SetVenta(100m);
            decimal totalRetail = p5.ObtenerImporteFinal(ventaMinorista);
            Console.WriteLine($"Total Minorista: {totalRetail}");

            Sale ventaMayorista = new WholesaleSale();
            ventaMayorista.SetVenta(100m);
            decimal totalWholesale = p5.ObtenerImporteFinal(ventaMayorista);
            Console.WriteLine($"Total Mayorista: {totalWholesale}");

            //PROBLEMA 6
            Console.WriteLine("\n=== PROBLEMA 6 ===");
            string entrada = "  cod 456 test  ";
            string salida = entrada.ToProductCode();
            Console.WriteLine(salida);

            string entradaNula = null;
            Console.WriteLine(entradaNula.ToProductCode());

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
