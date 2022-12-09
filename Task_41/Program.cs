// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите M-числа через пробелы: ");
int[] arrey = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int num = 0; 
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] > 0) num++;
}
Console.WriteLine($"Кол-во элементов больше 0 : {num}"); 

Console.WriteLine("Введите М-чисел через пробел : "); 
string m = Console.ReadLine(); 
int [] n = m.Split (' ').Select(Int32.Parse).ToArray();
Console.Write("Массив: ");
Console.WriteLine();
foreach (int i in n)
    Console.Write($"{i} ");
int count = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0) 
    count++;
}
Console.WriteLine();
Console.WriteLine($"Кол-во элементов больше 0 : {count}");

