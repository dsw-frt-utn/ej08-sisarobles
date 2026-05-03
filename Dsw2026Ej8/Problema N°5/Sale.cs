using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_5
{
    public class Sale
    {
        private decimal _venta;
        
        public virtual decimal CalculateTotal ()
        {
            return _venta;
        }

        public void SetVenta(decimal venta) => _venta = venta;
        public decimal GetVenta() => _venta;

    }
}
