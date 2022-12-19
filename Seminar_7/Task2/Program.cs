/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result - 1;
}


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
}


void SearchIndexMatrix(int m, int n, int[,] arr)
{
    if (m < 0 | m > arr.GetLength(0) - 1 | n < 0 | n > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемента нет");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[m, n]);
    }
}


int[,] matrix = GetMatrix(3, 4);

PrintMatrix(matrix);

int m = GetNumber("Введите позицию строки:");
int n = GetNumber("Введите позицию столбца:");

SearchIndexMatrix(m, n, matrix);