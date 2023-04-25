// Возведение числа A в натуральную степень B

Console.Clear();

int numb1 = GetNumbersFromUser1("Введите число A: ", "Ошибка ввода.Повторите попытку!");
int numb2 = GetNumbersFromUser2("Введите число B: ", "Ошибка ввода.Повторите попытку!");

int result = GetExponentiationByNumbers(numb1, numb2);

PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int GetNumbersFromUser1(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number1))
            return number1;
        Console.WriteLine(errorMessage);
    }

}

int GetNumbersFromUser2(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int number2))
            return number2;
        Console.WriteLine(errorMessage);
    }
}

int GetExponentiationByNumbers(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result *number1;
    }
    return result;
}

void PrintReport(int result)
{
    Console.WriteLine($"Число A возведённое в натуральную степень B -> {result}");
}