// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число А : ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число В : ");
int b = Convert.ToInt16(Console.ReadLine());
double x = Math.Pow (a, b);
Console.WriteLine($"Число {a} в {b}-ой степени = {x}");
