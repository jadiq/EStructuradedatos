////Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.

//public class ejercicio1
//{
//    public static void Main(string[] args)
//    {
//        ImprimirNumerosPares(1);
//    }

//    public static void ImprimirNumerosPares(int numero)
//    {
//        if (numero > 100)
//        {
//            return;
//        }

//        if (numero % 2 == 0)
//        {
//            Console.WriteLine(numero);
//        }

//        ImprimirNumerosPares(numero + 1);
//    }
//}


////Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.


//public class ejercicio2
//{
//    public static void Main(string[] args)
//    {
//        int n = 10; // Aquí puedes cambiar el valor de n
//        int suma = SumaRecursiva(n);
//        Console.WriteLine("La suma de los números del 1 al {0} es: {1}", n, suma);
//    }

//    public static int SumaRecursiva(int n)
//    {
//        if (n == 1)
//        {
//            return 1;
//        }

//        return n + SumaRecursiva(n - 1);
//    }
//}


////Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.
//public class ejercicio3
//{
//    public static void Main(string[] args)
//    {
//        int n = 5; // Aquí puedes cambiar el valor de n
//        ImprimirPiramide(n);
//    }

//    public static void ImprimirPiramide(int n)
//    {
//        if (n == 0)
//        {
//            return;
//        }

//        ImprimirPiramide(n - 1);

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(i + " ");
//        }

//        Console.WriteLine();
//    }
//}


////Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int n = 5; // Aquí puedes cambiar el valor de n
//        ImprimirPiramideInvertida(n);
//    }
//    public static void ImprimirPiramideInvertida(int n)
//    {
//        if (n == 0)
//        {
//            return;
//        }

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(n - i + 1 + " ");
//        }

//        Console.WriteLine();

//        ImprimirPiramideInvertida(n - 1);
//    }
//}


////Ejercicio 5: Escribe una función recursiva que imprima la tabla de multiplicar del n. 
//public class ejercicio6
//{
//    public static void Main(string[] args)
//    {
//        int n = 5; // Aquí puedes cambiar el valor de n
//        ImprimirTablaMultiplicar(n);
//    }

//    public static void ImprimirTablaMultiplicar(int n, int multiplicador = 1)
//    {
//        if (multiplicador > 10)
//        {
//            return;
//        }

//        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");

//        ImprimirTablaMultiplicar(n, multiplicador + 1);
//    }
//}



//Arreglos y Matrices:



//ejercicio 6) Crea una matriz de números reales. 


//using System.Numerics;

//double[,] matriz = new double[3, 3] { { 1.5, 2.7, 3.2 }, { 4.1, 5.9, 6.4 }, { 7.3, 8.6, 9.0 } };

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//7) Crea una matriz de números complejos.


//using System;
//using System.Numerics;

//Complex[,] matriz = new Complex[3, 3] {
//    { new Complex(1, 2), new Complex(3, 4), new Complex(5, 6) },
//    { new Complex(7, 8), new Complex(9, 10), new Complex(11, 12) },
//    { new Complex(13, 14), new Complex(15, 16), new Complex(17, 18) }
//};

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}



////8) Crea una matriz de matrices.

//int[][] matriz = new int[3][];

//matriz[0] = new int[2];
//matriz[1] = new int[3];
//matriz[2] = new int[4];

//matriz[0][1] = 5;


//9) Accede al elemento central de una matriz.

//int[,] matriz = new int[5, 5];

//// Acceder al tamaño de la matriz
//int filas = matriz.GetLength(0);
//int columnas = matriz.GetLength(1);

//// Acceder al elemento central
//int filaCentral = filas / 2;
//int columnaCentral = columnas / 2;
//int elementoCentral = matriz[filaCentral, columnaCentral];


////10) Suma dos matrices de diferentes tamaños.

//int[,] matrizA = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int[,] matrizB = new int[2, 2] { { 10, 11 }, { 12, 13 } };

//int filasA = matrizA.GetLength(0);
//int columnasA = matrizA.GetLength(1);
//int filasB = matrizB.GetLength(0);
//int columnasB = matrizB.GetLength(1);

//if (filasA == filasB && columnasA == columnasB)
//{
//    int[,] matrizSuma = new int[filasA, columnasA];

//    for (int i = 0; i < filasA; i++)
//    {
//        for (int j = 0; j < columnasA; j++)
//        {
//            matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j];
//        }
//    }
//    Console.WriteLine("La matriz suma es:");
//    for (int i = 0; i < filasA; i++)
//    {
//        for (int j = 0; j < columnasA; j++)
//        {
//            Console.Write(matrizSuma[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("Las matrices no tienen el mismo tamaño y no se pueden sumar.");
//}


////11) Multiplica una matriz por un número.

//int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int numero = 2;

//int filas = matriz.GetLength(0);
//int columnas = matriz.GetLength(1);

//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        matriz[i, j] *= numero;
//    }
//}

//// Imprimir la matriz resultante
//for (int i = 0; i < filas; i++)
//{
//    for (int j = 0; j < columnas; j++)
//    {
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//12) Calcula la media de los elementos de una matriz. 
//int[,] matriz1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//int filas1 = matriz1.GetLength(0);
//int columnas1 = matriz1.GetLength(1);
//int suma = 0;
//int totalElementos = filas1 * columnas1;

//for (int i = 0; i < filas1; i++)
//{
//    for (int j = 0; j < columnas1; j++)
//    {
//        suma += matriz1[i, j];
//    }
//}
//double media = (double)suma / totalElementos;
//Console.WriteLine("La media de los elementos de la matriz es: " + media);


//Ejercicio Matrices: 

//Ejercicio 1:Crea una matriz de números aleatorios de tamaño 100x100.

//Random random = new Random();
//int[,] matriz = new int[100, 100];

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        matriz[i, j] = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
//        Console.Write(matriz[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Ejercicio 2:Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

//int[,] matriz = new int[100, 100];
//Random random = new Random();

//Llenar la matriz con números aleatorios
//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        matriz[i, j] = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100
//    }
//}

//Calcular la media
//double suma = 0;
//int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        suma += matriz[i, j];
//    }
//}

//double media = suma / totalElementos;

//Calcular la mediana
//List<int> listaElementos = new List<int>();

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        listaElementos.Add(matriz[i, j]);
//    }
//}

//listaElementos.Sort();

//double mediana;
//if (totalElementos % 2 == 0)
//{
//    int indiceMedio1 = totalElementos / 2 - 1;
//    int indiceMedio2 = totalElementos / 2;
//    mediana = (listaElementos[indiceMedio1] + listaElementos[indiceMedio2]) / 2.0;
//}
//else
//{
//    int indiceMedio = totalElementos / 2;
//    mediana = listaElementos[indiceMedio];
//}

//Calcular la desviación estándar
//double sumaCuadrados = 0;

//for (int i = 0; i < matriz.GetLength(0); i++)
//{
//    for (int j = 0; j < matriz.GetLength(1); j++)
//    {
//        double desviacion = matriz[i, j] - media;
//        sumaCuadrados += desviacion * desviacion;
//    }
//}

//double desviacionEstandar = Math.Sqrt(sumaCuadrados / totalElementos);

//Imprimir los resultados en pantalla
//Console.WriteLine("La media de los elementos de la matriz es: " + media);
//Console.WriteLine("La mediana de los elementos de la matriz es: " + mediana);
//Console.WriteLine("La desviación estándar de los elementos de la matriz es: " + desviacionEstandar);




//Ejercicio 3:Escribe una función que encuentre el elemento máximo de una matriz.

//int[,] matriz2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//int maximo = EncontrarMaximo(matriz2);

//Console.WriteLine("El elemento máximo de la matriz es: " + maximo);

//// Función para encontrar el elemento máximo de una matriz
//int EncontrarMaximo(int[,] matriz2)
//{
//    int maximo = matriz2[0, 0];

//    for (int i = 0; i < matriz2.GetLength(0); i++)
//    {
//        for (int j = 0; j < matriz2.GetLength(1); j++)
//        {
//            if (matriz2[i, j] > maximo)
//            {
//                maximo = matriz2[i, j];
//            }
//        }
//    }

//    return maximo;
//}


////Ejercicio 4:Escribe una función que encuentre la submatriz de mayor suma de una matriz. 

//int[,] matriz = new int[4, 4] { { 1, 2, -3, 4 }, { -5, 6, 7, 8 }, { 9, 10, 11, -12 }, { 13, -14, 15, 16 } };

//EncontrarSubmatrizMayorSuma(matriz);

//// Función para encontrar la submatriz de mayor suma en una matriz
//void EncontrarSubmatrizMayorSuma(int[,] matriz)
//{
//    int filas = matriz.GetLength(0);
//    int columnas = matriz.GetLength(1);
//    int maxSuma = int.MinValue;
//    int inicioFila = 0, finFila = 0, inicioColumna = 0, finColumna = 0;

//    for (int i = 0; i < filas; i++)
//    {
//        for (int j = 0; j < columnas; j++)
//        {
//            for (int k = i; k < filas; k++)
//            {
//                for (int l = j; l < columnas; l++)
//                {
//                    int suma = 0;

//                    for (int m = i; m <= k; m++)
//                    {
//                        for (int n = j; n <= l; n++)
//                        {
//                            suma += matriz[m, n];
//                        }
//                    }

//                    if (suma > maxSuma)
//                    {
//                        maxSuma = suma;
//                        inicioFila = i;
//                        finFila = k;
//                        inicioColumna = j;
//                        finColumna = l;
//                    }
//                }
//            }
//        }
//    }

//    Console.WriteLine("La submatriz de mayor suma es:");

//    for (int i = inicioFila; i <= finFila; i++)
//    {
//        for (int j = inicioColumna; j <= finColumna; j++)
//        {
//            Console.Write(matriz[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}



////Ejercicio 5:Escribe una función que encuentre la matriz de covarianza de dos matrices.

double[,] matriz1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
double[,] matriz22 = new double[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

CalcularMatrizCovarianza(matriz1, matriz22);

// Función para calcular la matriz de covarianza de dos matrices
void CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz22)
{
    int filas = matriz1.GetLength(0);
    int columnas = matriz1.GetLength(1);

    if (filas != matriz22.GetLength(0) || columnas != matriz22.GetLength(1))
    {
        Console.WriteLine("Las matrices deben tener las mismas dimensiones.");
        return;
    }

    double[,] matrizCovarianza = new double[filas, columnas];

    // Calcular la media de cada matriz
    double mediaMatriz1 = CalcularMedia(matriz1);
    double mediaMatriz2 = CalcularMedia(matriz22);

    // Calcular la matriz de covarianza
    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            double covarianza = 0;

            for (int k = 0; k < filas; k++)
            {
                covarianza += (matriz1[i, k] - mediaMatriz1) * (matriz22[j, k] - mediaMatriz2);
            }

            matrizCovarianza[i, j] = covarianza / filas;
        }
    }

    // Imprimir la matriz de covarianza en pantalla
    Console.WriteLine("La matriz de covarianza es:");

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            Console.Write(matrizCovarianza[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Función para calcular la media de una matriz
double CalcularMedia(double[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);
    double suma = 0;

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            suma += matriz[i, j];
        }
    }

    return suma / (filas * columnas);
}


















