// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите день недели цифрой:");
string dayNumber = Console.ReadLine();
int dayNum=Convert.ToInt32(dayNumber);

if (dayNum<1){
    Console.WriteLine("Вы ввели недопустимое значение. Введите (от 1 до 7)");
}

if (dayNum>0)
{
    if (dayNum<8)
    {
        if (dayNum<6){
            Console.WriteLine($"НЕ выходной");
        }

        if (dayNum>5){
            Console.WriteLine("Выходной");
        }
    } else 
    {
        Console.WriteLine("Вы ввели число больше 7");
    }
}


