// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt16(Console.ReadLine());
int[] arrey = new int[size];
for (int i = 0; i < size; i++)
{
    arrey[i] = new Random().Next(100, 1000); 
    Console.Write(arrey[i] + " ");
}
Console.WriteLine();
Console.Write($"Чётные числа: ");
int even_number = 0;
int number_even_numbers = 0;
for (int i = 0; i < size; i++) 
{
    if (arrey[i] % 2 == 0)
    {
        even_number = arrey[i];
        number_even_numbers++;
        Console.Write(even_number + " ");
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {number_even_numbers} ");