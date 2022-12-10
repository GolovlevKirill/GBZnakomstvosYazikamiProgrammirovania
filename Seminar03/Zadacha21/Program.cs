// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в 3D пространстве(X,Y,Z)");
Console.WriteLine("Координата X первой точки:");
string X1 = Console.ReadLine();
int x1 = Convert.ToInt32(X1);
Console.WriteLine("Координата Y первой точки:");
string Y1 = Console.ReadLine();
int y1 = Convert.ToInt32(Y1);
Console.WriteLine("Координата Z первой точки:");
string Z1 = Console.ReadLine();
int z1 = Convert.ToInt32(Z1);

Console.WriteLine("Координата X второй точки:");
string X2 = Console.ReadLine();
int x2 = Convert.ToInt32(X2);
Console.WriteLine("Координата Y второй точки:");
string Y2 = Console.ReadLine();
int y2 = Convert.ToInt32(Y2);
Console.WriteLine("Координата Z второй точки:");
string Z2 = Console.ReadLine();
int z2 = Convert.ToInt32(Z2);

Console.WriteLine($"Вы ввели координаты точек A({x1}, {y1}, {z1}) B({x2}, {y2}, {z2})");

// Вычесление расстояние между точками:

double distance= Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))+((z2-z1)*(z2-z1)));

Console.WriteLine($"Расстояние между точками в 3D пространстве: {distance}");

//int number = Convert.ToInt32(Number);
// Когда string до конвертации почему не могут быть 
// переменные с одним и тем же именем?