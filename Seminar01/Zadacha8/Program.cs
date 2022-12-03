// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
string numberN = Console.ReadLine();
Console.WriteLine($"Вы ввели число: {numberN}");
int nN = Convert.ToInt32(numberN);
int a = 1;

while (a<nN)
{
    if (a < nN)
    {
        a = a+1;
        if (a%2==0)
        {
            Console.WriteLine($"{a}");
        }
    }
}
