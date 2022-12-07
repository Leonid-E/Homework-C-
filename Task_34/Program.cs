// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt16(Console.ReadLine());
int[] arrey = new int[size];
int number_even_numbers = 0;
for (int i = 0; i < size; i++)
{
    arrey[i] = new Random().Next(100, 1000); 
    Console.Write(arrey[i] + " ");
    if (arrey[i] % 2 == 0) number_even_numbers++;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {number_even_numbers} ");