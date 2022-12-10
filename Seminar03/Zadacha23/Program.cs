// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
string n = Console.ReadLine();
int N = Convert.ToInt32(n);

void cub()
{
    
    int step = 1;
    while (step <= N)
    {
        int result = step * step * step;
        
        Console.WriteLine($"{result}");
        step = step + 1;
    }
    
}
cub();