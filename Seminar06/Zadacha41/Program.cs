// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = new int[5];
int i = 0;

// Заполнение массива
System.Console.WriteLine("Введите числа");
Random rnd = new Random();

int count = 0;
for (i = 0; i < 5; i = i+1)
    {
        string M = Console.ReadLine();
        int m = Convert.ToInt32(M);
        array[i] = m;    
        
        if (array[i]>0)
        {
            count = count + 1;
        }   
    }

System.Console.WriteLine("Чисел больше ноля:"+count);
