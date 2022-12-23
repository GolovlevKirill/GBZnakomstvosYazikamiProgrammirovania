// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.WriteLine("Введите параметры первой прямой(b1,k1):");
string B1 = Console.ReadLine();
int b1 = Convert.ToInt32(B1);
string K1 = Console.ReadLine();
int k1 = Convert.ToInt32(K1);

System.Console.WriteLine("Введите параметры второй прямой(b2,k2):");
string B2 = Console.ReadLine();
int b2 = Convert.ToInt32(B2);
string K2 = Console.ReadLine();
int k2 = Convert.ToInt32(K2);

if(k1==k2)
    {
        System.Console.WriteLine("Прямые не пересекаются");
    }
else
    {
    float x = (b2 - b1) / (k1 - k2);
    float y = k1 * x + b1;
    System.Console.WriteLine($"Точка пересечения: ({x},{y})");
    }