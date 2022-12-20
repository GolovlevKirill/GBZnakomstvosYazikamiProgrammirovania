// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//
// [3, 7, 23, 12] -> 19
//
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];
int i = 0;

// Заполнение массива
System.Console.WriteLine("Заполнение массива:");
Random rnd = new Random();
for (i = 0; i < 5; i = i+1)
    {
        array[i]=rnd.Next(1,999);
        System.Console.WriteLine(array[i]);

    
    }

// Нахождение суммы эллеменитов
System.Console.WriteLine("Эллементы на нечетных позициях массива:");

int j = 0;
int result = 0;
for (j = 0; j < 5; j = j + 2)
        {
            result = result + array[j];
            System.Console.WriteLine(array[j]);
        }

Console.WriteLine("Сумма эллементов на нечетных позициях равна: "+result);
