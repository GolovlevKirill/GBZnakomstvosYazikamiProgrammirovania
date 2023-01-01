// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите числа M и N. \nЧисло N должно быть больше M.");
System.Console.WriteLine();
Console.Write("Введите число M: ");
string M = Console.ReadLine();
int numberM = Convert.ToInt32(M);

Console.Write("Введите число N: ");
string N = Console.ReadLine();
int numberN = Convert.ToInt32(N);


if (numberN>=numberM)
{
findSum(numberM, numberN);

// вызов функции для компенсации m-1"
void findSum(int m, int n)
{
    Console.Write(resultSum(m - 1, n));
}

// функция нахождения суммы
int resultSum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + resultSum(m, n);
        return result;
    }
}

System.Console.WriteLine();
}
else
{
    System.Console.WriteLine();
    System.Console.Write("число M:" + numberM + " > числа N:" + numberN);
    System.Console.Write("\nЧисло N должно быть больше M.");
    System.Console.WriteLine();
}
