// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    int temp = m;
    m = n; 
    n = temp;
}
int Sum(int num)
{
    if (num == m) return m;
    return num + Sum(num - 1);
}
Console.WriteLine (Sum(n));
