// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте размер массива: ");
int a = Convert.ToInt16(Console.ReadLine());
int[] arrey = new int[a];
int length = arrey.Length;
int odd_number = 0;
int sum_number = 0; // сумма элементов на нечётных позициях
for (int i = 0; i < length; i++)
{
    arrey[i] = new Random().Next(-100, 100); 
    Console.Write(arrey[i] + " ");
    if (i % 2 != 0)
    {
        odd_number = arrey[i];
        sum_number = sum_number + odd_number;
    }
}
Console.WriteLine();
Console.Write($"Cумма элементов на нечётных позициях: {sum_number}");  