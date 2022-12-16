// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
string na = Console.ReadLine();
int nA = Convert.ToInt32(na);

Console.WriteLine("Введите число B:");
string nb = Console.ReadLine();
int nB = Convert.ToInt32(nb);

int step = 1;
int result = 1;
while (step <= nB)
{
    result = result * nA;
    step = step + 1;
} 

Console.WriteLine($"Число {nA} в степени {nB} = {result}");  
//Console.WriteLine($"Число {nA} в степени {nB} = {result}");    
   

