using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_1
{
    partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto (long code, string description, decimal price)
        {
            return $"[{code} {description} {Separador} {price:C}]";
        }
    }

}
