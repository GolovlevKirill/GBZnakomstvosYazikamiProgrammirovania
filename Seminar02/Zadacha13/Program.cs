// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);



if (num<0)
{
    num=num*(-1);
}

if (num>999)
    {
        while(num>999)
        {
            num=num/10;
        }
    }

if (num>99)
{
    if (num<1000)
    {
      num = num%10;
      
      Console.WriteLine($"Третья цифра числа: {num}");  
    }
    
  

} 
else
{
    Console.WriteLine("Тертьей цифры нет.");
}



