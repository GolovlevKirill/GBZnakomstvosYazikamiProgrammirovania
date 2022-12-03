// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
string numberA = Console.ReadLine();
int nA = Convert.ToInt32(numberA);


if (nA%2 == 0)
{
    Console.WriteLine($"Число {nA} - четное");
}

else {
    
    Console.WriteLine($"Число {nA} - НЕ четное");
}