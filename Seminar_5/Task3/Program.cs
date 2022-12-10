/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

// Инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0, 100);
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

// Получаем максимальное число в массиве.
int GetMaxNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
            max = arr[i];
    }

    return max;
}

// Получаем минимальное число в массиве.
int GetMinNumber(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
    }

    return min;
}

int[] arr = InitArray(5);
PrintArray(arr);
int max = GetMaxNumber(arr);
int min = GetMinNumber(arr);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");
