// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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


System.Console.WriteLine("Введите число:");
string Number = Console.ReadLine();
int number = Convert.ToInt32(Number);

bool numInArray = false;

{
for (i = 0; i < n; i = i + 1)
    {
        for (j = 0; j < m; j = j + 1)
        {
            if (number == array[j,i])
            {
            numInArray = true;
            System.Console.Write("Число "+number+" есть в массиве.");

            }

        }
        System.Console.WriteLine();
    }
}
if (numInArray == false) System.Console.WriteLine("Числа "+number+" нет в массиве."); 
