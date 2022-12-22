/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18

*/

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ProductTwoMatrices(int[,] matrixa, int[,] matrixb)
{
    int[,] matrixc = GetMatrix(matrixa.GetLength(0), matrixb.GetLength(1));
    for (int i = 0; i < matrixa.GetLength(0); i++)
    {
        for (int j = 0; j < matrixb.GetLength(1); j++)
        {
            matrixc[i, j] = 0;
            for (int k = 0; k < matrixa.GetLength(1); k++)
            {
                matrixc[i, j] = matrixc[i, j] + matrixa[i, k] * matrixb[k, j];
            }
        }
    }
    return matrixc;
}


int[,] matrixa = GetMatrix(2, 2);
Console.WriteLine("Матрица а");
PrintMatrix(matrixa);

int[,] matrixb = GetMatrix(2, 2);
Console.WriteLine("Матрица b");
PrintMatrix(matrixb);

int[,] matrixc = ProductTwoMatrices(matrixa, matrixb);
Console.WriteLine("Результирующая матрица будет: ");
PrintMatrix(matrixc);