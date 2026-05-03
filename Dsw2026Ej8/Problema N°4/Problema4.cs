using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_N_4
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int notasValidas = 0;

            ProcesarNota(nota1, ref suma, ref notasValidas);
            ProcesarNota(nota2, ref suma, ref notasValidas);
            ProcesarNota(nota3, ref suma, ref notasValidas);

            if (notasValidas == 0)
            {
                return 0;
            }

            return suma / notasValidas;
        }

        private void ProcesarNota(int? nota, ref double suma, ref int contador)
        {
            if (nota != null && nota.Value >= 0 && nota.Value <= 10)
            {
                suma += nota.Value;
                contador++;
            }
        }
        
    }
}
