using System;

namespace Metodos_y_Arrays___C2_Ej4
{
    class Factorial
    {
        public double calculafactorial(int numero)
        {
            double factorial = numero;
            int i = numero;

            do
            {
                i = i - 1;
                factorial = factorial * i;
            } while (i > 1);
            return factorial;
        }
        static void Main(string[] args)
        {
            int numero;
            Factorial elfactorial = new Factorial();
            Console.WriteLine("Introduce un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(elfactorial.calculafactorial(numero));

        }
    }
}
