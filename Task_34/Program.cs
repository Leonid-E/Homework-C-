// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Создайте размер массива: ");
int a = Convert.ToInt16(Console.ReadLine());
int[] arrey = new int [a];
int length = arrey.Length;
int number_of_even_numbers = 0;
int number_of_odd_numbers = 0;
for (int i = 0; i < length; i++)
{
    arrey[i] = new Random().Next(100, 1000); 
    Console.Write(arrey[i] + " ");
}  
Console.WriteLine();
Console.WriteLine("Проверка чисел на чётность: ");
for (int i = 0; i < length; i++)
{
    if (arrey[i] % 2 == 0)
    Console.WriteLine($"{arrey[i]} чётное ");
    else
    Console.WriteLine($"{arrey[i]} нечётное "); 
}
        