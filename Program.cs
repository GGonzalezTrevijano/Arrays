using System;

namespace Proyecto4_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ARRAYS

            // Sintaxis 1

            Console.WriteLine("Sintaxis 1");

            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 0;
            arreglo[2] = 20;
            arreglo[3] = -5;
            arreglo[4] = 8;

            Console.WriteLine(arreglo[1]);

            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            
            // Sintaxis 2

            Console.WriteLine("Sintaxis 2");

            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(vocales[2]);

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            // Sintaxis 3

            Console.WriteLine("Sintaxis 3");

            double[] numero = { 1.1, 2.2, 3.3, 4.4 };

            Console.WriteLine("Tamaño de numeros: {0}", numero.Length);  // numero.Length muestra la cantidad de numeros dentro del array

            // Mostrar el ultimo valor del array
            Console.WriteLine(numero[numero.Length - 1]);

            Console.Write("\r\n");

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            //ITERAR ARRAYS

            int[] array = { 10, 5, 2, -2, -5, -10 };

            //Uso del for

            Console.WriteLine("Iterar arreglo con el uso del For");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.Write("\r\n");

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            //Uso del foreach

            Console.WriteLine("Iterar Array con ciclor for each");

            foreach (int num in array)  //La variable foreach recoge cada valor del Array y lo muestra numero por numero hasta acabar el ciclo.
            {
                Console.Write("{0} ", num);
            }

            Console.Write("\r\n");

            //----------------------------------------------------------------------------------------------------------------------------------------------------------
            
            //Uso del Lenght

            string[] cadenas = {"hola ", "mundo ", "ciclos ", "array ", "cadenas " };
            Console.WriteLine("Iterar array con ciclo for pero en orden inverso");

            for (int i = cadenas.Length -1; i >= 0; i--)
            {
                Console.Write("{0}", cadenas[i]);
            }

            Console.Write("\r\n");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO - Peticion de datos para el array al usuario - EJERCICIO

            Console.WriteLine("Tamaño de tu array");

            int valores = Convert.ToInt32(Console.ReadLine()); //Variable que almacena los valores insertados por el usuario

            int[] tamaño = new int[valores];    //Array que almacenara los numeros

                for (int i = 0; i < tamaño.Length ; i++)    //For que se ejecutara del 0 al numero del array
                {
                    Console.WriteLine("Escribe numero en el indice {0}", i); //Pregunta los numeros a insertar en el array empezando por el 0
                    tamaño[i] = Convert.ToInt32(Console.ReadLine());  //Solicita los numeros al usuario y los almacena en la variable tamaño
                }

            Console.WriteLine("Los numeros que ingresaste son:");
            MostrarArray(tamaño);

            Console.Write("\r\n");

            //EL METODO MostrarArray PERTENECE A ESTE EJERCICIO 

            //----------------------------------------------------------------------------------------------------------------------------------------------------------

            //CLASE ARRAY

            Console.WriteLine("Copiar Arrays");

            int[] lista = { 30, 40, 50, 60, 70 }; //Array normal
            int[] temp = new int[lista.Length]; //Guarda la cantidad de valores del array "Lista"

            //Guarda una copia del arreglo "Lista"

            Array.Copy(lista, temp, lista.Length);  //Copia todos los elementos con (lista.Lenght) en el array temp

            Console.Write("Array Original (list): ");
            MostrarArray(lista);

            Console.Write("Array Copia (temp): ");
            MostrarArray(temp);

            //Invertir el Array

            Array.Reverse(temp);    //Muestra el array en orden inverso
            Console.WriteLine("Array Invertido: ");
            MostrarArray(temp);

            //Ordenar el Array

            Array.Sort(lista);
            Console.WriteLine("Array ordenado: "); //Ordenado de menos a mayor siempre
            MostrarArray(lista);

            Console.Write("\r\n");

            //--------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO - Peticion de datos y media del Array - EJERCICIO

            Console.WriteLine("¿Cuantas notas tienes?");

            int notas = int.Parse(Console.ReadLine());

            int[] datos = new int[notas];

            double suma = 0;

            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write("Inserta la nota {0}: ", i + 1);
                datos[i] = int.Parse(Console.ReadLine());

                suma += datos[i]; //Suma el 1º valor con el 2º, el 2º con el 3º y así suvesivamente realizando la suma.
            }

            double resultado = suma / datos.Length;
            Console.WriteLine("Tu media es: {0}", resultado);

            Console.Write("\r\n");
        

        //----------------------------------------------------------------------------------------------------------------------------------------------------------

            //ARAYS MULTIDIMENSIONALES (MATRICES)
            
            Console.WriteLine("Array Multidimensional");

            //Array con 3 filas y 2 columnas
            int[,] a = new int[3 , 2] { {1,1}, {2,2}, {2,4} };    //Generas 3 Filas de 2 Columnas, los datos de los corchetes son los de la 1º fila.

            //Mostrar Array

            for (int i = 0 ; i < a.GetLength(0) ; i++)  //GetLenght indica la dimensión de las filas
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("El Array en la posición [{0}, {1}] = {2}", i, j, a[i, j]);
                }
            }

            Console.Write("\r\n");

            Console.WriteLine("Array Tridimensional");

            //Array tridimensional
            int[,] matriz = new int[3, 3] { { 5, 1, 3 }, { 2, 4, 6 }, { 4, 6, 8} };

            for (int i = 0; i < matriz.GetLength(0); i++)  //GetLenght indica la dimensión de las filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }

            //OPERACIONES CON MATRICES

            double[,] matrizA = { { 1.1, 0.3 }, { 5.5, 8 } };
            double[,] matrizB = { { 6, -2.1, }, { 0, 10.8 } };

            Console.WriteLine("Matriz A");

            MostrarMatriz(matrizA);

            Console.WriteLine("Matriz B");

            MostrarMatriz(matrizB);

            Console.Write("\r\n");

            //Suma de matrices

            double[,] sumamatriz = new double[2, 2];

            for (int i = 0; i < sumamatriz.GetLength(0); i++)
            {
                for (int j = 0; j < sumamatriz.GetLength(1); i++)
                {
                   sumamatriz[i, j] = matrizA[i, j] + matrizB[i, j];  
                }
            }
            Console.WriteLine("A + B");
            MostrarMatriz(sumamatriz);
        } 
        //----------------------------------------------------------------------------------------------------------------------------------------------------------

        //METODO MOSTRAR MATRIZ
        public static void MostrarMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); i++)
                {
                    Console.Write("{0.0#0 }", matriz[i, j]);    //{0.0#0} --> El 1º 0 es el numero de la matriz, el resto es el formato en el que se van a mostrar los numeros de tu matriz.
                }
                Console.WriteLine("");
            }
        }

        //METODO MOSTRAR ARRAY
        public static void MostrarArray(int[] array) 
        {
            foreach (int num in array)
            {
                Console.Write("{0} ", num); 
            }
            Console.WriteLine();
        }
    }
}
