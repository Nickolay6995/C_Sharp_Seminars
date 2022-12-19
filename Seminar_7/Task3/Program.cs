/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

    return result;
}


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 9);
        }
    }
    return matrix;
}


double[] InitArray(int dimension)
{
    double[] array = new double[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = 0;
    }

    return array;
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

//Вычесление среднего арифметического
double[] ArithmeticMean(int[,] arr)
{
    int len = arr.GetLength(0);
    double[] array = InitArray(arr.GetLength(1));
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        array[i] = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[i] = array[i] + Convert.ToDouble(arr[j, i]);
        }
        array[i] = array[i] / len;
    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0:f1}", array[i]);
        Console.Write("; ");
    }
    Console.WriteLine();
}

int[,] matrix = GetMatrix(3, 4);
PrintMatrix(matrix);

double[] arr = ArithmeticMean(matrix);
PrintArray(arr);