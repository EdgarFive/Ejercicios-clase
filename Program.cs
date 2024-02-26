/*
do
{
    x = x + 2;
    Console.WriteLine(x);
} while (x <= 9);*/
// ENUNCIADO 1 =============================================================
using System.ComponentModel;

Console.WriteLine("\nEjerlcicio 1\n");
for (int i = 0; i <= 9;)
{
    i = i + 2;
    Console.WriteLine(i);
}
Console.WriteLine("\nEjercicio 2\n");
int x = 0;
for (int j = 0; j <= 10; ++j)
{
    x = x+j;
}
Console.WriteLine(x);
//Enunciado 2 =============================================================0
Console.WriteLine("\nENUNCIADO 2\n");
int eenum = 0;
int eeresul = 0;
do
{
    Console.WriteLine("1. Ingrese un número positivo e ingrese uno negativo si quiere salir del bucle");
    eeresul = eenum + eeresul;
    eenum = int.Parse(Console.ReadLine());
} while (eenum > 0);
Console.WriteLine("La suma de los números ingresados es: " + eeresul);
Console.ReadKey();

Console.WriteLine("\n2. Encontrar el primer número entero divisible entre 7 y 11");
int ecantidad = 2;
int ecanti1 = 1;
int ecanti2 = 1;
int emenu = 0;
do
{
    ecantidad++;
    ecanti1 = ecantidad % 7;
    ecanti2 = ecantidad % 11;
    if (ecanti1 == 0 && ecanti2 == 0)
    {
        emenu = -1;
    }
} while (emenu != -1);
Console.WriteLine("El número divisible entre 7 y 11 es: " + ecantidad);
Console.ReadKey();


