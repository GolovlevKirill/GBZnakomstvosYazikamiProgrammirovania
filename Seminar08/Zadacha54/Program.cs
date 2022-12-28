// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3;
int n = 7;

int[,] array = new int[m,n];

Random rnd = new Random();
int i;
int j;

for (i = 0; i < m; i = i + 1)
    {
        for (j = 0; j < n; j = j + 1)
        {
            array[i,j] = rnd.Next(0,999);
            System.Console.Write(array[i,j]+" ");

        }
        System.Console.WriteLine();
    } 

System.Console.WriteLine(array.GetLength(1));

for (i = 0; i < m; i = i + 1)
    {
        for (int s = array.GetLength(1)-1; s > 0; s = s - 1)
        {
            for (j = array.GetLength(1)-1; j > 0; j = j - 1)
            {
                if (array[i,j]>array[i,j-1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j-1];
                    array[i,j-1] = temp;
                }    
            }

        }
            
    }
        System.Console.WriteLine();

// Вывод отсортированного массива:

for (i = 0; i < m; i = i + 1)
    {
        for (j = 0; j < n; j = j + 1)
        { 
            System.Console.Write(array[i,j]+" ");

        }
        System.Console.WriteLine();
    } 

System.Console.WriteLine();