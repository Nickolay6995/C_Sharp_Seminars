/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int GetNumber(string text)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(text);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

int Summ(int m, int n)
{
    int result = 0;
    if (m < n)
    {
        result = (n + m) * (n - m + 1) / 2;
    }
    return result;
}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int sum = Summ(m, n);

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} -> {sum}");