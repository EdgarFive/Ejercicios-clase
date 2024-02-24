/*
do
{
    x = x + 2;
    Console.WriteLine(x);
} while (x <= 9);*/
Console.WriteLine("Ejerlcicio 1\n");
for (int i = 0; i <= 9;)
{
    i = i + 2;
    Console.WriteLine(i);
}
Console.WriteLine("Ejercicio 2\n");
int x = 0;
for (int j = 0; j <= 10; ++j)
{
    x = x+j;
}
Console.WriteLine(x);
//Enunciado 3 =============================================================0
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

