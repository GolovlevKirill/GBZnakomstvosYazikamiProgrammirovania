// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num<0)
{
    num=num*(-1);
}

if (num>99)
{
    if (num<1000)
    {
      num = num/10;
      num = num%10;
      
      Console.WriteLine($"Вторая цифра числа: {num}");  
    }
} 
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}


