// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
//
// [345, 897, 568, 234] -> 2

int[] array = new int[5];
int i;

// Заполнение массива
System.Console.WriteLine("Заполнение массива:");
Random rnd = new Random();
        for(i = 0; i < 5; i = i+1)
        {
            array[i] = rnd.Next(1,999);
            System.Console.WriteLine(array[i]);;
        }

// Проверка на четность
System.Console.WriteLine("Проверка на четность:");

int count = 0;
for(i = 0; i < 5; i = i+1)
        {
            if (array[i] % 2 == 0)
            {
                count = count + 1;
                System.Console.WriteLine(array[i]+" четное");
            }
            else System.Console.WriteLine(array[i]+" не четное");

        }

           
System.Console.WriteLine("Колличество четных чисел в массиве:"+count);