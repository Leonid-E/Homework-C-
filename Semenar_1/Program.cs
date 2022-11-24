
Random random = new Random();         // такой же класс как Console
int number = random.Next(10, 100);    // метод генерирования случайных чисел от  (не включают числа), [включают числа]
Console.WriteLine("Random namber = {0}" , number);
int a = number / 10;
int b = number % 10;
if (a > b)
    Console.WriteLine(" a > b, {0} " , b);
else if (b > a)
    Console.WriteLine(" b > a, {0} " , b);
else
    Console.WriteLine(" b == a, {0} " , a);
