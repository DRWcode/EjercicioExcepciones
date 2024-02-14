using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    internal class Operaciones
    {
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return a / b;
        }
    }
}
