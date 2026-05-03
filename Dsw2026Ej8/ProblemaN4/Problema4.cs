using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.ProblemaN4
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int contador = 0;

            void Promedio(int? nota)
            {
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    contador++;
                }
            }

            Promedio(nota1);
            Promedio(nota2);
            Promedio(nota3);

            if (contador == 0) return 0;

            return (double)suma / contador;
        }
    }
}