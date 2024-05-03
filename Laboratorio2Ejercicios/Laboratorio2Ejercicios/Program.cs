

//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 

Console.WriteLine("ingrese un numero: ");
double num1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese otro numero");
double num2 = int.Parse(Console.ReadLine());
double suma = num1 + num2;
double resta = num2 - num1;
double multiplicacion = num1 * num2;
double division = num1 / num2;

Console.WriteLine("el resultado de las operaciones de suma es:  "
    + suma + "  de resta es:  " + resta + "  de la multiplicacion:  " + multiplicacion + "  de la division:  " + division);



//2) Solicita un número al usuario y determina si es par o impar. 
Console.WriteLine("ingrese un numero: ");
double num = double.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("el numero:" + num + " es par");
}
else
{
    Console.WriteLine("el numero:" + num + " es impar");
}



//3) Pide la base y la altura de un triángulo al usuario y calcula su área. 

Console.WriteLine("Ingrese la base del triángulo: ");
double baseTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del triángulo: ");
double alturaTriangulo = double.Parse(Console.ReadLine());

double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("El área del triángulo es: " + areaTriangulo);

//4) Crea una función que calcule la factorial de un número. 

int calcularelFactorial(int numero)
{
    if (numero == 0)
    {
        return 1;
    }
    else
    {
        int factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
int resultado = calcularelFactorial(6);
Console.WriteLine("El factorial de 6 es: " + resultado);

//5) Verifica si un número ingresado por el usuario es primo o no. 

Console.WriteLine("Ingrese un número entero positivo: ");
int numero = int.Parse(Console.ReadLine());
bool esPrimo = true;

if (numero <= 1)
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
    Console.WriteLine(numero + " es un número primo.");
}
else
{
    Console.WriteLine(numero + " no es un número primo.");
}

//6) Toma una cadena de texto y muestra su inversión. 

Console.WriteLine("Ingrese una cadena de texto: ");
string texto = Console.ReadLine();

char[] caracteres = texto.ToCharArray();
Array.Reverse(caracteres);
string textoInvertido = new string(caracteres);

Console.WriteLine("La cadena invertida es: " + textoInvertido);


//7) Calcula la suma de los números pares en un rango especificado por el usuario. 

Console.WriteLine("Ingrese el límite inferior del rango: ");
int limiteInferior = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el límite superior del rango: ");
int limiteSuperior = int.Parse(Console.ReadLine());

int sumaPares = 0;

for (int i = limiteInferior; i <= limiteSuperior; i++)
{
    if (i % 2 == 0)
    {
        sumaPares += i;
    }
}

Console.WriteLine("La suma de los números pares en el rango es: " + sumaPares);

//8) Crea una lista de los cuadrados de los primeros 10 números naturales. 

List<int> cuadrados = new List<int>();

for (int i = 1; i <= 10; i++)
{
    cuadrados.Add(i * i);
}

Console.WriteLine("Los cuadrados de los primeros 10 números naturales son: ");
foreach (int cuadrado in cuadrados)
{
    Console.Write(cuadrado + " ");
}

//9) Cuenta el número de vocales en una cadena de texto.

Console.WriteLine("Ingrese una cadena de texto: ");
string texto1 = Console.ReadLine().ToLower(); // Convertir a minúsculas para simplificar las comparaciones

int contadorVocales = 0;

foreach (char caracter in texto1)
{
    if ("aeiou".Contains(caracter)) // Verificar si el carácter es una vocal
    {
        contadorVocales++;
    }
}

Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);


//10) Genera los primeros 10 números de la serie Fibonacci. 

int n = 10; // Número de términos de la serie Fibonacci a generar
int a = 0, b = 1;

Console.WriteLine("Los primeros 10 números de la serie de Fibonacci son: ");

for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");
    int temp = a;
    a = b;
    b = temp + b;
}

//11) Ordena una lista de números ingresados por el usuario de menor a mayor. 

Console.WriteLine("Ingrese los números separados por espacios: ");
string input = Console.ReadLine();
string[] numerosString = input.Split(' ');
List<int> numeros = new List<int>();

foreach (string numero11 in numerosString)
{
    if (int.TryParse(numero11, out int parsedNumero))
    {
        numeros.Add(parsedNumero);
    }
}

numeros.Sort();

Console.WriteLine("Los números ordenados de menor a mayor son: ");
foreach (int numero11 in numeros)
{
    Console.Write(numero + " ");
}

//12) Verifica si una palabra ingresada por el usuario es un palíndromo.

Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine().ToLower(); 
bool esPalindromo = true;

for (int i = 0; i < palabra.Length / 2; i++)
{
    if (palabra[i] != palabra[palabra.Length - 1 - i])
    {
        esPalindromo = false;
        break;
    }
}

if (esPalindromo)
{
    Console.WriteLine("La palabra ingresada es un palíndromo.");
}
else
{
    Console.WriteLine("La palabra ingresada no es un palíndromo.");
}
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario.

Console.WriteLine("Ingrese un número para generar su tabla de multiplicar: ");
int numero12 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tabla de multiplicar del " + numero12 + ":");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numero12 + " x " + i + " = " + numero12 * i);
}

//14) Pide el radio de un círculo al usuario y calcula su área. 

Console.WriteLine("Ingrese el radio del círculo: ");
double radio = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);

//15) Toma un número entero y calcula la suma de sus dígitos.

Console.WriteLine("Ingrese un número entero: ");
int numero13 = Convert.ToInt32(Console.ReadLine());

int sumaDigitos = 0;
int numeroActual = numero;

while (numeroActual != 0)
{
    int digito = numeroActual % 10;
    sumaDigitos += digito;
    numeroActual /= 10;
}

Console.WriteLine("La suma de los dígitos del número " + numero13 + " es: " + sumaDigitos);
