/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

int GetNumber(string message)
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
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int SummDigitNum(int number)
{
    int count = Convert.ToString(number).Length;
    int digitNum = 0;
    int summ = 0;
    for (int i = 0; i <= count; i++)
    {
        digitNum = number - number % 10;
        summ = summ + (number - digitNum);
        number = number / 10;
    }

    return summ;
}

int number = GetNumber("Введите число: ");
int summ = SummDigitNum(number);

Console.WriteLine($"Сумма цифр введённого числа = {summ}");