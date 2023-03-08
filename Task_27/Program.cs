Console.Clear();
int num = GetNumberFromUser("Введите число: ", "Ошибка ввода");
int sum = GetSumOfDigits(num);
Console.WriteLine($"Сумма цифр числа {num} равна {sum}");

int GetSumOfDigits(int orig)
{
    int summa = 0;
    while (orig > 0)
    {
        summa += orig % 10;
        orig = orig / 10;
    }
    return summa;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
