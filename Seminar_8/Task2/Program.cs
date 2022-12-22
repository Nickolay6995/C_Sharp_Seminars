/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] InitArray(int dimension)
{
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = 0;
    }

    return array;
}


int[] ArithmeticMean(int[,] arr)
{

    int[] array = InitArray(arr.GetLength(0));
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        array[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i] = array[i] + arr[i, j];
        }
    }
    return array;
}


void lineSmallestSumElements(int[] matrix)
{
    int count = 1;
    int tmp = matrix[0];
    for (int i = 1; i < matrix.Length; i++)
    {
        if (tmp > matrix[i])
        {
            tmp = matrix[i];
            count = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count} строка");
}
void PrintArray(int[] array)
{
    Console.WriteLine("Сумма элементов в строке:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}


int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);
int[] arr = ArithmeticMean(matrix);
PrintArray(arr);
lineSmallestSumElements(arr);