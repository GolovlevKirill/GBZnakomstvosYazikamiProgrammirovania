// See Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, 
// а какое меньшее.Console.WriteLine("Введите два числа: ");
string numberA = Console.ReadLine();
string numberB = Console.ReadLine();
int nA = Convert.ToInt32(numberA);
int nB = Convert.ToInt32(numberB);

if (nA > nB)
{
    Console.WriteLine($"Максимальным является первое число : {nA}");
}
else {
    Console.WriteLine($"Максимальным является второе число : {nB}");
}