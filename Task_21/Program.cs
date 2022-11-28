// Задача 21. Напиcсать программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. 

Console.WriteLine("Введите координаты первой точки (x, y, z): ");
int X1 = Convert.ToInt32(Console.ReadLine());
int Y1 = Convert.ToInt32(Console.ReadLine());
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки (x, y, z): ");
int X2 = Convert.ToInt32(Console.ReadLine());
int Y2 = Convert.ToInt32(Console.ReadLine());
int Z2 = Convert.ToInt32(Console.ReadLine());

double a, b, c, d;
a = Math.Pow((X2 - X1), 2);
b = Math.Pow((Y2 - Y1), 2);
c = Math.Pow((Z2 - Z1), 2);
d = Math.Sqrt((a + b + c));

Console.WriteLine($"Расстояние между двумя точками : {Math.Round(d, 2)}");

