/*

Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

*/


int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1, 9);
    }

    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int GetNumberFromConsole(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }

    return result;
}

// Создаваём копию
int[] CopyArray(int[] art)
{
    int len = art.Length;
    int[] array = new int[len];


    for (int i = 0; i < len; i++)
    {
        array[i] = art[i];
    }

    return array;
}
int dimension = GetNumberFromConsole("Введите размерность массива:");
int[] startArray = InitArray(dimension);
Console.WriteLine("Создан массив с элементами");

PrintArray(startArray);
int[] resultArray = CopyArray(startArray);
Console.WriteLine("Создана копия массива с элементами");

PrintArray(resultArray);
PrintArray(resultArray);