// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] arrey = new double[size];
double max_num = arrey [0];
double min_num = arrey [0];
for (int i = 1; i < arrey.Length; i++)
{
    arrey[i] = new Random().Next(-10, 10);
    Console.Write(arrey[i] + " ");
    if (arrey[i] > max_num)
        max_num = arrey[i];
    if (arrey[i] < min_num)
        min_num = arrey[i];
}
Console.WriteLine();
Console.WriteLine("Максимальное число: " + max_num);
Console.WriteLine("Минимальное число: " + min_num);
Console.WriteLine($"Разница между числами: {max_num - min_num}");
