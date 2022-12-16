// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int Number = Convert.ToInt32(number);
double result=0;
int lastNumber=0;
while(Number>10)
{
    double a = Number % 10;
    Console.WriteLine($"{a}");
    Number = Number/10;
    Console.WriteLine($"{Number}");
    result = result + a;
    lastNumber=Number;
}
result=result+lastNumber;
Console.WriteLine($"Результат: {result}");