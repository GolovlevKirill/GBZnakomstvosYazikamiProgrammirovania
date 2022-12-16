// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array;
array = new int[8];

int step=0;

Console.WriteLine("Введите 8 эллементов массива:");
int maxEllemets=8;

while(step<maxEllemets)
{
    string number=Console.ReadLine();
    int Number = Convert.ToInt32(number);
    array[step]= Number;
    step=step+1;    
}

Console.Write(array[0]);
Console.Write(" ");
Console.Write(array[1]);
Console.Write(" ");
Console.Write(array[2]);
Console.Write(" ");
Console.Write(array[3]);
Console.Write(" ");
Console.Write(array[4]);
Console.Write(" ");
Console.Write(array[5]);
Console.Write(" ");
Console.Write(array[6]);
Console.Write(" ");
Console.WriteLine(array[7]);