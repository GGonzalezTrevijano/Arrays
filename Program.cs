using System;

namespace Proyecto4_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS
             
            // Sintaxis 1
            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 0;
            arreglo[2] = 20;
            arreglo[3] = -5;
            arreglo[4] = 8;

            Console.WriteLine(arreglo[1]);

            // Sintaxis 2
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(vocales[2]);

            // Sintaxis 3
            double[] numero = { 1.1, 2.2, 3.3, 4.4 };

            Console.WriteLine("Tamaño de numeros: {0}", numero.Length);

                    // Mostrar el ultimo valor
                    Console.WriteLine(numero[numero.Length - 1]);

            Console.Write("\r\n");

            //Itinerar Arrays
            int[] array = { 10, 5, 2, -2, -5, -10 };

            Console.WriteLine("Iterar arreglo con el uso del For");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.Write("\r\n");

            Console.WriteLine("Iterar Array con ciclor for each");

            foreach (int num in array)  //La variable foreach recoge cada valor del Array y lo muestra numero por numero hasta acabar el ciclo.
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
