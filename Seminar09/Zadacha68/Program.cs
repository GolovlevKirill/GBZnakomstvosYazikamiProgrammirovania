﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
string M = Console.ReadLine();
int numberM = Convert.ToInt32(M);

Console.Write("Введите число N: ");
string N = Console.ReadLine();
int numberN = Convert.ToInt32(N);


void AkkermanFunction(int m, int n)
{
    Console.Write(AkkermanResult(m, n)); 
}

// функция Аккермана
int AkkermanResult(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanResult(m - 1, 1);
    }
    else
    {
        return (AkkermanResult(m - 1, AkkermanResult(m, n - 1)));
    }
}


AkkermanFunction(numberM,numberN);
System.Console.WriteLine();