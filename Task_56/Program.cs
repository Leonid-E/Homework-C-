// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

 Console.WriteLine("Введите количество строк: ");
int stroki = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [stroki, columns];
Random rand = new Random();

int height = array.GetLength(0);
int width = array.GetLength(1);

Console.WriteLine("Массив : ");

for (int y = 0; y < height; y++)
{
    for (int x = 0; x < width; x++)
    {
        array [y, x] = rand.Next(10);
        Console.Write($"{array[y, x]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("Сумма элементов в каждой строке: ");

int[] arr = new int[height];
for (int y = 0; y < height; y++)
{
    int sum = 0;
    for (int x = 0; x < width; x++)
    {
        sum += array[y, x];
    }
    arr[y] = arr[y] + sum;
    Console.Write($"{arr[y]} ");
}
Console.WriteLine();
int numbersStringMin = arr[0];
int indesStringMin = 0;
for (int y = 1; y < arr.Length; y++)
{
    if (arr[y] < numbersStringMin)
    {
        numbersStringMin = arr[y];
        indesStringMin = y;
    }
}
Console.Write($"Номер строки с наименьшим числом: {indesStringMin + 1}");

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine($"Строка с наименьшей суммой: {GetRowNumber(array)}");

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//           result[i, j] = new Random().Next(min, max +1);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int GetRowNumber (int [,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0,i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           sum = sum + array[i,j];
//         }
//         if (minsum > sum)
//         {
//           minsum = sum;
//           row = i;
//         }
//     }
//     return row + 1;
// }