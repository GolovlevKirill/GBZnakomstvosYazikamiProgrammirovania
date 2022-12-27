// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


System.Console.WriteLine("Введите размерность двумерного массива:");
string M = Console.ReadLine();
string N = Console.ReadLine();

int m = Convert.ToInt32(M);
int n = Convert.ToInt32(N);

int[,] array = new int[m,n];

Random rnd = new Random();
int i;
int j;

for (i = 0; i < n; i = i + 1)
    {
        for (j = 0; j < m; j = j + 1)
        {
            array[j,i] = rnd.Next(0,99);
            System.Console.Write(array[j,i]+" ");

        }
        System.Console.WriteLine();
    }

System.Console.WriteLine();
float result = 0;
for (i = 0; i < m; i = i + 1)
{
    result = 0;
    for (j = 0; j < n; j = j + 1)
    {
        result = result + array[i, j];
    }
    System.Console.Write(result/n+" ");
}
System.Console.WriteLine();

