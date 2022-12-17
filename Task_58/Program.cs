// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matr1 = new int[,]
{
    { 2, 4 },
    { 3, 2 }
};
int[,] matr2 = new int[,]
{
    { 3, 4 },
    { 3, 3 }
};
for (int y = 0; y < matr1.GetLength(0); y++)
{
    for (int x = 0; x < matr1.GetLength(1); x++)
        Console.Write($"{matr1[y, x]} "); 
    Console.WriteLine();
}
Console.WriteLine("---");

for (int y = 0; y < matr2.GetLength(0); y++)
{
    for (int x = 0; x < matr2.GetLength(1); x++)
        Console.Write($"{matr2[y, x]} ");
    Console.WriteLine();
}
int[,] matrMult = new int[2,2];
for (int y = 0; y < 2; y++)
{
    for (int x = 0; x < 2; x++)
    {
        for (int k = 0; k < 2; k++)
        {
            matrMult[y,x] = matrMult[y,x] + matr1[y,k] * matr2[k,x]; 
        }
    }
}
Console.WriteLine("Произведение матриц: ");
for (int y = 0; y < matrMult.GetLength(0); y++)
{
    for (int x = 0; x < matrMult.GetLength(1); x++)  
    {    
        Console.Write($"{matrMult[y, x]} "); 
    }
    Console.WriteLine();
}
