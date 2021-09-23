using System;

/*
    Programa encontra a soma de todos os inteiros de 1 a 20
    divisiveis por 3.
*/

for (int i = 1; i <= 20; i ++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine($"{i} é divisível por 3");
    }
}