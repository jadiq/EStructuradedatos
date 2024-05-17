//1.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números
//primos.


public class ejercicio1
{
    public static void Main()
    {
        // Ejemplo de uso de la función
        List<int> numeros = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> primos = ObtenerNumerosPrimos(numeros);

        Console.WriteLine("Números primos:");
        foreach (int primo in primos)
        {
            Console.WriteLine(primo);
        }
    }

    public static List<int> ObtenerNumerosPrimos(List<int> numeros)
    {
        List<int> primos = new List<int>();

        foreach (int numero in numeros)
        {
            bool esPrimo = true;

            if (numero < 2)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                primos.Add(numero);
            }
        }

        return primos;
    }
}



//2.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//comienzan con una letra determinada.


//public class ejercicio2
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<string> palabras = new List<string>() { "hola", "adiós", "gato", "perro", "casa" };
//        List<string> palabrasComienzanConA = ObtenerPalabrasComienzanCon(palabras, 'a');

//        Console.WriteLine("Palabras que comienzan con 'a':");
//        foreach (string palabra in palabrasComienzanConA)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalabrasComienzanCon(List<string> palabras, char letra)
//    {
//        List<string> palabrasComienzanCon = new List<string>();

//        foreach (string palabra in palabras)
//        {
//            if (palabra.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
//            {
//                palabrasComienzanCon.Add(palabra);
//            }
//        }

//        return palabrasComienzanCon;
//    }
//}


//3.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//son divisibles por un número determinado.

//public class ejercicio3
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<int> numeros = new List<int>() { 10, 15, 20, 25, 30, 35, 40 };
//        List<int> numerosDivisibles = ObtenerNumerosDivisibles(numeros, 5);

//        Console.WriteLine("Números divisibles por 5:");
//        foreach (int numero in numerosDivisibles)
//        {
//            Console.WriteLine(numero);
//        }
//    }
//    public static List<int> ObtenerNumerosDivisibles(List<int> numeros, int divisor)
//    {
//        List<int> numerosDivisibles = new List<int>();
//        foreach (int numero in numeros)
//        {
//            if (numero % divisor == 0)
//            {
//                numerosDivisibles.Add(numero);
//            }
//        }
//        return numerosDivisibles;
//    }
//}


//4. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que 
//están en ambos conjuntos.

//public class Ejercicio4
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
//        HashSet<int> conjunto2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
//        HashSet<int> numerosComunes = ObtenerNumerosComunes(conjunto1, conjunto2);

//        Console.WriteLine("Números comunes en ambos conjuntos:");
//        foreach (int numero in numerosComunes)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static HashSet<int> ObtenerNumerosComunes(HashSet<int> conjunto1, HashSet<int> conjunto2)
//    {
//        return new HashSet<int>(conjunto1.Intersect(conjunto2));
//    }
//}


//5. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
//están en el primer conjunto pero no en el segundo.


//public class ejercicio5
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
//        HashSet<int> conjunto2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
//        HashSet<int> numerosEnConjunto1NoEnConjunto2 = ObtenerNumerosEnConjunto1NoEnConjunto2(conjunto1, conjunto2);

//        Console.WriteLine("Números en conjunto1 pero no en conjunto2:");
//        foreach (int numero in numerosEnConjunto1NoEnConjunto2)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static HashSet<int> ObtenerNumerosEnConjunto1NoEnConjunto2(HashSet<int> conjunto1, HashSet<int> conjunto2)
//    {
//        return new HashSet<int>(conjunto1.Except(conjunto2));
//    }
//}

//6. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
//están en el segundo conjunto pero no en el primero.


//public class ejercicio6
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
//        HashSet<int> conjunto2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
//        HashSet<int> numerosEnConjunto2NoEnConjunto1 = ObtenerNumerosEnConjunto2NoEnConjunto1(conjunto1, conjunto2);

//        Console.WriteLine("Números en conjunto2 pero no en conjunto1:");
//        foreach (int numero in numerosEnConjunto2NoEnConjunto1)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static HashSet<int> ObtenerNumerosEnConjunto2NoEnConjunto1(HashSet<int> conjunto1, HashSet<int> conjunto2)
//    {
//        return new HashSet<int>(conjunto2.Except(conjunto1));
//    }
//}





//7. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son anagramas.


//public class ejercicio7
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<string> palabras = new List<string>() { "roma", "amor", "perro", "roper" };
//        List<string> anagramas = ObtenerAnagramas(palabras);

//        Console.WriteLine("Anagramas encontrados:");
//        foreach (string palabra in anagramas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//    public static List<string> ObtenerAnagramas(List<string> palabras)
//    {
//        List<string> anagramas = new List<string>();

//        foreach (string palabra in palabras)
//        {
//            char[] caracteres = palabra.ToCharArray();
//            Array.Sort(caracteres);
//            string palabraOrdenada = new string(caracteres);

//            if (palabras.Count(p => new string(p.ToCharArray().OrderBy(c => c).ToArray()) == palabraOrdenada) > 1)
//            {
//                anagramas.Add(palabra);
//            }
//        }
//        return anagramas;
//    }
//}


//8. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos.


//public class ejercicio8
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<string> palabras = new List<string>() { "ana", "oso", "casa", "radar" };
//        List<string> palindromos = ObtenerPalindromos(palabras);

//        Console.WriteLine("Palíndromos encontrados:");
//        foreach (string palabra in palindromos)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//    public static List<string> ObtenerPalindromos(List<string> palabras)
//    {
//        List<string> palindromos = new List<string>();

//        foreach (string palabra in palabras)
//        {
//            string palabraReversa = new string(palabra.Reverse().ToArray());

//            if (palabra.Equals(palabraReversa, StringComparison.OrdinalIgnoreCase))
//            {
//                palindromos.Add(palabra);
//            }
//        }

//        return palindromos;
//    }
//}



//9. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//tienen una longitud determinada. 


//public class Ejercicio9 { 
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<string> palabras = new List<string>() { "casa", "perro", "gato", "auto" };
//        int longitudDeseada = 4;
//        List<string> palabrasConLongitud = ObtenerPalabrasConLongitud(palabras, longitudDeseada);

//        Console.WriteLine($"Palabras de longitud {longitudDeseada}:");
//        foreach (string palabra in palabrasConLongitud)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalabrasConLongitud(List<string> palabras, int longitud)
//    {
//        return palabras.Where(p => p.Length == longitud).ToList();
//    }
//}



//10. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que 
//contienen una letra determinada.


//public class Ejercicio10
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        List<string> palabras = new List<string>() { "casa", "perro", "gato", "auto" };
//        char letraDeterminada = 'o';
//        List<string> palabrasConLetra = ObtenerPalabrasConLetra(palabras, letraDeterminada);

//        Console.WriteLine($"Palabras que contienen la letra '{letraDeterminada}':");
//        foreach (string palabra in palabrasConLetra)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalabrasConLetra(List<string> palabras, char letra)
//    {
//        return palabras.Where(p => p.Contains(letra)).ToList();
//    }
//}


//11.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de menor a mayor.


//public class ejercicio11
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 5, 2, 8, 1, 3 };
//        List<int> numerosOrdenados = ObtenerNumerosOrdenados(numeros);

//        Console.WriteLine("Números ordenados de menor a mayor:");
//        foreach (int numero in numerosOrdenados)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static List<int> ObtenerNumerosOrdenados(HashSet<int> numeros)
//    {
//        return numeros.OrderBy(n => n).ToList();
//    }
//}

//12. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de mayor a menor.


//public class ejercicio12
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 5, 2, 8, 1, 3 };
//        List<int> numerosOrdenados = ObtenerNumerosOrdenados(numeros);

//        Console.WriteLine("Números ordenados de mayor a menor:");
//        foreach (int numero in numerosOrdenados)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static List<int> ObtenerNumerosOrdenados(HashSet<int> numeros)
//    {
//        return numeros.OrderByDescending(n => n).ToList();
//    }
//}


//13. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están duplicados.


//public class ejercicio13
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 2, 4, 5, 3 };
//        HashSet<int> numerosDuplicados = ObtenerNumerosDuplicados(numeros);

//        Console.WriteLine("Números duplicados encontrados:");
//        foreach (int numero in numerosDuplicados)
//        {
//            Console.WriteLine(numero);
//        }
//    }
//    public static HashSet<int> ObtenerNumerosDuplicados(HashSet<int> numeros)
//    {
//        HashSet<int> numerosDuplicados = new HashSet<int>();
//        HashSet<int> numerosUnicos = new HashSet<int>();

//        foreach (int numero in numeros)
//        {
//            if (!numerosUnicos.Add(numero))
//            {
//                numerosDuplicados.Add(numero);
//            }
//        }

//        return numerosDuplicados;
//    }
//}


//14. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//no están duplicados.


//public class ejercicio14
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 2, 4, 5, 3 };
//        HashSet<int> numerosNoDuplicados = ObtenerNumerosNoDuplicados(numeros);

//        Console.WriteLine("Números no duplicados encontrados:");
//        foreach (int numero in numerosNoDuplicados)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static HashSet<int> ObtenerNumerosNoDuplicados(HashSet<int> numeros)
//    {
//        HashSet<int> numerosNoDuplicados = new HashSet<int>();

//        foreach (int numero in numeros)
//        {
//            if (numeros.Count(n => n == numero) == 1)
//            {
//                numerosNoDuplicados.Add(numero);
//            }
//        }

//        return numerosNoDuplicados;
//    }
//}


//15. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//son primos y están ordenados de menor a mayor.


//public class ejercicio15
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 2, 5, 10, 7, 3, 9 };
//        List<int> numerosPrimosOrdenados = ObtenerNumerosPrimosOrdenados(numeros);

//        Console.WriteLine("Números primos ordenados de menor a mayor:");
//        foreach (int numero in numerosPrimosOrdenados)
//        {
//            Console.WriteLine(numero);
//        }
//    }
//    public static List<int> ObtenerNumerosPrimosOrdenados(HashSet<int> numeros)
//    {
//        List<int> numerosPrimos = new List<int>();

//        foreach (int numero in numeros)
//        {
//            if (EsPrimo(numero))
//            {
//                numerosPrimos.Add(numero);
//            }
//        }

//        numerosPrimos.Sort();

//        return numerosPrimos;
//    }

//    public static bool EsPrimo(int numero)
//    {
//        if (numero <= 1)
//        {
//            return false;
//        }

//        for (int i = 2; i <= Math.Sqrt(numero); i++)
//        {
//            if (numero % i == 0)
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//}


//16. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos y están ordenadas de menor a mayor.


//public class ejercicio16
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<string> palabras = new HashSet<string>() { "ama", "reconocer", "casa", "radar", "oso" };
//        List<string> palabrasPalindromasOrdenadas = ObtenerPalabrasPalindromasOrdenadas(palabras);

//        Console.WriteLine("Palabras palíndromas ordenadas de menor a mayor:");
//        foreach (string palabra in palabrasPalindromasOrdenadas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }
//    public static List<string> ObtenerPalabrasPalindromasOrdenadas(HashSet<string> palabras)
//    {
//        List<string> palabrasPalindromas = new List<string>();

//        foreach (string palabra in palabras)
//        {
//            if (EsPalindromo(palabra))
//            {
//                palabrasPalindromas.Add(palabra);
//            }
//        }

//        palabrasPalindromas.Sort();

//        return palabrasPalindromas;
//    }
//    public static bool EsPalindromo(string palabra)
//    {
//        string reversa = new string(palabra.Reverse().ToArray());

//        return palabra == reversa;
//    }
//}



//17. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//tienen una longitud determinada y están ordenadas de menor a mayor. 


//public class ejercicio17
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<string> palabras = new HashSet<string>() { "casa", "perro", "gato", "manzana", "sol" };
//        int longitudDeseada = 4;
//        List<string> palabrasFiltradasOrdenadas = ObtenerPalabrasPorLongitud(palabras, longitudDeseada);

//        Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas de menor a mayor:");
//        foreach (string palabra in palabrasFiltradasOrdenadas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalabrasPorLongitud(HashSet<string> palabras, int longitud)
//    {
//        List<string> palabrasFiltradas = palabras.Where(p => p.Length == longitud).ToList();
//        palabrasFiltradas.Sort();

//        return palabrasFiltradas;
//    }
//}




//18.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//contienen una letra determinada y están ordenadas de mayor a menor.


//public class Ejercicio18
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<string> palabras = new HashSet<string>() { "casa", "perro", "gato", "manzana", "sol" };
//        char letraDeseada = 'o';
//        List<string> palabrasFiltradasOrdenadas = ObtenerPalabrasPorLetra(palabras, letraDeseada);

//        Console.WriteLine($"Palabras que contienen la letra '{letraDeseada}' ordenadas de mayor a menor:");
//        foreach (string palabra in palabrasFiltradasOrdenadas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalabrasPorLetra(HashSet<string> palabras, char letra)
//    {
//        List<string> palabrasFiltradas = palabras.Where(p => p.Contains(letra)).ToList();
//        palabrasFiltradas.Sort();
//        palabrasFiltradas.Reverse();

//        return palabrasFiltradas;
//    }
//}




//19. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de menor a mayor y que no están duplicados. 



//public class ejercicio19
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<int> numeros = new HashSet<int>() { 2, 1, 3, 5, 4, 2, 6 };
//        SortedSet<int> numerosOrdenadosNoDuplicados = ObtenerNumerosOrdenadosNoDuplicados(numeros);

//        Console.WriteLine("Números ordenados de menor a mayor y sin duplicados:");
//        foreach (int numero in numerosOrdenadosNoDuplicados)
//        {
//            Console.WriteLine(numero);
//        }
//    }

//    public static SortedSet<int> ObtenerNumerosOrdenadosNoDuplicados(HashSet<int> numeros)
//    {
//        SortedSet<int> numerosOrdenadosNoDuplicados = new SortedSet<int>(numeros);

//        return numerosOrdenadosNoDuplicados;
//    }
//}



//20. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor. 


//public class ejercicio20
//{
//    public static void Main()
//    {
//        // Ejemplo de uso de la función
//        HashSet<string> palabras = new HashSet<string>() { "ana", "oso", "casa", "radar", "sol" };
//        int longitudDeseada = 3;
//        List<string> palabrasFiltradasOrdenadas = ObtenerPalindromosPorLongitud(palabras, longitudDeseada);

//        Console.WriteLine($"Palíndromos de longitud {longitudDeseada} ordenados de menor a mayor:");
//        foreach (string palabra in palabrasFiltradasOrdenadas)
//        {
//            Console.WriteLine(palabra);
//        }
//    }

//    public static List<string> ObtenerPalindromosPorLongitud(HashSet<string> palabras, int longitud)
//    {
//        List<string> palabrasFiltradas = palabras.Where(p => p.Length == longitud && EsPalindromo(p)).ToList();
//        palabrasFiltradas.Sort();

//        return palabrasFiltradas;
//    }

//    public static bool EsPalindromo(string palabra)
//    {
//        string reversa = new string(palabra.Reverse().ToArray());

//        return palabra == reversa;
//    }
//}
