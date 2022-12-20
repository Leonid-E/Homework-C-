// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число от 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int y = 1;
if (n >= 0)
{
    int num (int n, int y)
    {
        Console.Write($"{(n)} ");
        if (n == y) return n;
        return num(n - 1, y);
    }
    num(n, y);
}
else
Console.Write("Введите натуральное число от 1: ");
