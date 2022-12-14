/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/


int CheckNumberFromConsole(string massage)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(massage);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число.");
        }
    }

    return result;
}
int[] InitArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = CheckNumberFromConsole("Ведите значение:");
    }
    return array;
}
int CountPlus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int M = CheckNumberFromConsole("Введите размер массива:");
int[] array = InitArray(M);
Console.WriteLine(CountPlus(array));
