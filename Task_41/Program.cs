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




// int number_greater_than_0 = 1;
// for (int i = 0; i < arrey.Length; i++)
// {
//     if (arrey[i] > 0)
//     number_greater_than_0 = arrey[i]; 
//     number_greater_than_0++;
// }
// Console.Write(number_greater_than_0 + " ");
