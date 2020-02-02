﻿using System;

namespace Proyecto4_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARREGLOS
             
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
        }
    }
}
