//Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-ти значное число:");
string Number = Console.ReadLine();
int number = Convert.ToInt32(Number);

int a;
int b;
int c;
int d;
int e;

a = number % 10;
b = (number / 10)%10;
c = (number / 100) % 10;
d = (number / 1000) % 10;
e = number / 10000;

/*
int[] listNumber = new listNumber[5]
listNumber[0]=[a];
listNumber[1]=[b];
listNumber[2]=[c];
listNumber[3]=[d];
listNumber[4]=[e];
*/


// Проверка на пятизначность
if (number>9999 && number<100000)
{
    if (e == a && d == b)
    {
        Console.WriteLine($"Число {number} является полиндромом");
    }
    else {
        Console.WriteLine($"Число {number} НЕ является полиндромом");
    }
} else {Console.WriteLine($"Число {number} НЕ пятизначное!");}


// Должен ли метод быть объявлен в начале? Как C# читает код?


