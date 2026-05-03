using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal ()
        {
            return base.CalculateTotal() * 0.90m;
        }
    }
}
