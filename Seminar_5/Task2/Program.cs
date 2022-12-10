/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

// Инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }

    return array;
}

// Печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Получаем сумму чисел, стоящих на нечётных позициях в массиве.
int GetSumNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }

    return sum;
}

int[] arr = InitArray(4);
PrintArray(arr);
int sum = GetSumNumber(arr);

Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях в массиве = {sum}");
