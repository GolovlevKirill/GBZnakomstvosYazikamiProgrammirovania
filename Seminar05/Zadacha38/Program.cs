// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76

int[] array = new int[5];
int i;

Random rnd = new Random();
System.Console.WriteLine("Заполнение массива:");
for (i = 0; i < 5; i = i + 1)
    {
        array[i] = rnd.Next(1,999);
        System.Console.WriteLine(array[i]);
    }


// Нахождение максимального и минимального эллемента массива
int max = array[0];
int count = 0;


while (count < 5)
{
    if (max <= array[count])
    {
        max = array[count];
    }
    
    count = count + 1;
}

System.Console.WriteLine("Максимальный эллемент в массиве:"+max);


int min = array[0];
count = 0;

while (count < 5)
{
    if (min >= array[count])
    {
        min = array[count];
    }
    
    count = count + 1;
}

System.Console.WriteLine("Минимальный эллемент в массиве:"+min);

int result;

result = max - min;
System.Console.WriteLine("Разница между максимальным и минимальным значениями:"+result);
// Нахождение разницы