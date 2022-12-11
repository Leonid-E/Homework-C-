// Задача 23. Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int a = 0;

Console.Write("Таблица кубов чисел : ");

while (i < n)
{
    a = a + 1;
    double b = Math.Pow(a, 3);
    Console.Write(b + ", ");
    i++;
}

    