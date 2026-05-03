using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CÓDIGO";
            }

            return code.Trim().ToUpper().Replace(" ", "-");
        }
    }
}
