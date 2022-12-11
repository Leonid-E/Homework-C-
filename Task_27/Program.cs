// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int [a];
int i = 0;
int sum = 0;

while (i < array.Length)
{
    int count = a % 10;    
    a = a / 10;
    sum = sum + count;
    i++;
}
Console.WriteLine($"Сумма всех чисел = {sum}");















