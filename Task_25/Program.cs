Console.Clear();
int numA = GetNumberFromUser("Введите число A: ", "Ошибка ввода");
int numB = GetNumberFromUser("Введите число B: ", "Ошибка ввода");
int result = MakeExponent(numA, numB);
Console.WriteLine($"{numA} ---> {result}");

int MakeExponent(int orig, int exp)
{
    int prod = 1;
    int count = 1;
    while (count <= exp)
    {
        prod = prod * orig;
        count++;
    }
    return prod;
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