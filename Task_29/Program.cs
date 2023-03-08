Console.Clear();
int[] array = new int[8];
int min = GetNumberFromUser("Введите начальное число для диапазона случайных чисел: ", "Ошибка ввода!");
int max = GetNumberFromUser("Введите конечное число для диапазона случайных чисел: ", "Ошибка ввода!");
if (min < max)
{
    FillArray(array, min, max);
    PrintArray(array);
}
else
    Console.WriteLine("Ошибка ввода, генерация случайных чисел в этом диапазоне невозможна!");


void FillArray(int[] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
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