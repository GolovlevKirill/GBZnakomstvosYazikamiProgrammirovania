// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Random rnd = new Random();

// определение 1-й матрицы
System.Console.WriteLine("1-я матрица:");
int i = 0;
int j = 0;

int m = 6;
int n = 3;

int[,] matrix1 = new int[m,n];

for (i = 0; i < m; i = i + 1)
    {
        for (j = 0; j < n; j = j + 1)
        {
            matrix1[i,j] = rnd.Next(1,4);
            System.Console.Write(matrix1[i,j]+" ");

        }
        System.Console.WriteLine();
    } 

// определение 2-й матрицы
System.Console.WriteLine();
System.Console.WriteLine("2-я матрица:");
int s = 3;
int k = 6;

int[,] matrix2 = new int[s,k];

for (i = 0; i < s; i = i + 1)
    {
        for (j = 0; j < k; j = j + 1)
        {
            matrix2[i,j] = rnd.Next(1,4);
            System.Console.Write(matrix2[i,j]+" ");

        }
        System.Console.WriteLine();
    }


// Умножение матриц

int[,] matrixResult = new int[matrix2.GetLength(1),matrix1.GetLength(0)];
System.Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы не согласованны!");
    return;
}else
{
for (i = 0; i < matrixResult.GetLength(0); i++)
{
    for (j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;
      for (k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrixResult[i,j] = sum;
    }
}
}


if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы не согласованны!");
    return;
}else
{
for (i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (j = 0; j < matrixResult.GetLength(1); j++)
        {
            Console.Write($"{matrixResult[i, j]} ");
        }
        Console.WriteLine();
    }
}
