// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите искомое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int [, ] array = new int [3, 4];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = random.Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int numbers = 0; // количество совпадений
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == x )
        {
            numbers = array[i,j];
            numbers++;
        }   
    }  
}
if (numbers == 0)
Console.Write($"Такого числа ({x}) нет в массиве"); 

// Console.Write("Введите искомое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int [, ] array = new int [3, 4];
// Random random = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array [i, j] = random.Next(10);
//         Console.Write($"{array[i, j]} ");
//     }
//     Console.WriteLine();
// }
// int numbers = 0; // количество совпадений
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (array[i,j] == x )
//         {
//             numbers = array[i,j];
//             numbers++;
//         }   
//     }  
// }
// if (numbers == 0)
// Console.Write($"Такого числа ({x}) нет в массиве"); 
