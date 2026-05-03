using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;

            Product copiaProducto = product;

            copiaProducto.SetDescription("Descripción Modificada");

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }

    }
}
