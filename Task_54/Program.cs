/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = new int [,] 
{ 
    { 1, 4, 7, 2 }, 
    { 5, 9, 2, 3 }, 
    { 8, 4, 2, 4 }
};
for(int y = 0; y < array.GetLength(0); y++ )
    {
    for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[y,x]} ");
        }
        Console.WriteLine();
    }
Console.WriteLine("-------");
for (int y = 0; y < array.GetLength(0); y++)
{
    for (int x = 0; x < array.GetLength(1); x++)
    {
        for (int i = 0; i < array.GetLength(1)-1; i++)
        {
            if (array[y, i] < array[y, i + 1])
            {
            int temp = array[y, i];
            array[y, i] = array[y, i + 1];
            array[y, i + 1] = temp;
            }
        }
    }
}  

for (int y = 0; y < array.GetLength(0); y++ )
    {
    for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write($"{array[y,x]} ");
        }
    Console.WriteLine();  
    }