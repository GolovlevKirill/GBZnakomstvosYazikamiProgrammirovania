// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
            array[j,i] = rnd.Next(-99,99);
            System.Console.Write(array[j,i]+" ");

        }
        System.Console.WriteLine();
    }



// System.Console.Write(array[m,n]);