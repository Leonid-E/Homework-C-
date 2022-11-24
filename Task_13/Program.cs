// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите любое число: ");
string a = Console.ReadLine();
if (Convert.ToInt32(a) < 100) 
{
    Console.WriteLine ("Третьей цифры нет");
} 
else 
{
    char[] arr = new char [a.Length];
    for (int i = 0; i < a.Length; i++) 
    {
        arr [i] = a[i];
    }
    Console.WriteLine ("Третья цифра : " + arr [2]);
}