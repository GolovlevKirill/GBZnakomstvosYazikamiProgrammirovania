//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа: ");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
string numberC = Console.ReadLine();
int nA = Convert.ToInt32(numberA);
int nB = Convert.ToInt32(numberB);
int nC = Convert.ToInt32(numberC);

int max = nA;

if (max < nB)
{
    max = nB;
}

if(max < nC) {
    max = nC;
}

Console.WriteLine($"Максимальное число: {max}");
