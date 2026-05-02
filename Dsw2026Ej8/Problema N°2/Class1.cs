using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_2
{
    public class Class1
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal valorTotal;
            if (quantity <= 0)
            {
                valorTotal = 0m;
            } else {
                valorTotal = quantity * unitPrice;
            }
            var anonima = new { Code = productCode , Description = productDescription, Quantity = quantity, Total = valorTotal };

            return $"{anonima.Code}-{anonima.Description}-{anonima.Total}";
        }
    }
}
