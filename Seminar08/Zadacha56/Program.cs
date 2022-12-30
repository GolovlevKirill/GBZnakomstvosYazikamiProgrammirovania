// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = 8;
int n = 4;

int[,] array = new int[m,n];

Random rnd = new Random();
int i;
int j;

for (i = 0; i < m; i = i + 1)
    {
        for (j = 0; j < n; j = j + 1)
        {
            array[i,j] = rnd.Next(0,9);
            System.Console.Write(array[i,j]+" ");

        }
        System.Console.WriteLine();
    } 


System.Console.WriteLine();

int[] arraySums = new int[m];

int sum = 0;
int temp = 0;

// нахождение суммы в строках
System.Console.WriteLine("Сумма значений в строках: ");
for (i = 0; i < m; i = i + 1)
    {
        for (j = 0; j < array.GetLength(1); j = j + 1)
        {
            sum = sum + array[i,j];

        }
        // System.Console.Write(sum+" ");
        arraySums[i] = sum;
        System.Console.WriteLine("Сумма в " + (i+1) + " строке: " +  arraySums[i]);

        sum = 0;
            
    }
    System.Console.WriteLine();

// нахождение минимального значения
int minValue = arraySums[0];
for (j=0; j < arraySums.Length; j++)
{
    if (arraySums[j] < minValue)
    {
        minValue = arraySums[j];
    }

}

// нахождения номера строки
for (j=0; j < arraySums.Length; j++)
{
    if (minValue == arraySums[j])
    {
        int result = j+1;
        System.Console.WriteLine("Номер строки с наименьшей суммой элементов: " + result);
    }

}
