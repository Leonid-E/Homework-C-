// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double [] arrey = new double[size];
double max_num = -999;
double min_num = +999;
for (int i = 0; i < size; i++)
{
    arrey[i] = new Random().Next(-999, 1000);
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
