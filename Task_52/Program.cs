// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [, ] array = new int [m, n];
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = random.Next(10);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Среднее арифметическое каждого столбца: "); 
for (int j = 0; j < array.GetLength(1); j++)
{
    double temp = 0;
    double sumColumn = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
       temp = array [i,j];
       sumColumn = sumColumn + temp;
    } 
    Console.Write($"{Math.Round(sumColumn / m, 1)} \t");
}