/*

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

*/

int[,] GetMatrix(int N)
{
    int[,] matrix = new int[N, N];
    for (int ik = 0; ik < N; ik++)
        for (int jk = 0; jk < N; jk++)
            matrix[ik, jk] = 0;

    for (int ik = 0; ik < N; ik++)
    {
        for (int jk = 0; jk < N; jk++)
        {
            int i = ik + 1;
            int j = jk + 1;
            int switcher = (j - i + N) / N;
            int Ic = Math.Abs(i - N / 2 - 1) + (i - 1) / (N / 2) * ((N - 1) % 2);
            int Jc = Math.Abs(j - N / 2 - 1) + (j - 1) / (N / 2) * ((N - 1) % 2);
            int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring - 1;
            int Coef = 4 * Ring * (N - Ring);
            matrix[ik, jk] = Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);
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

int[,] matrix = GetMatrix(4);
PrintMatrix(matrix);