// Программа по поиску суммы цифр в заданном числе

Console.Clear();

int numb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода.Повторите попытку!");

int result = GetSumByNumber(numb);

PrintReport(result);

/////////////////////////////////////////////////////////////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int number))
        return number;
    Console.WriteLine(errorMessage);
    }
}

int GetSumByNumber(int number)
{
    int sum = 0;
    while(number / 10 >= 0)
    {
        sum = sum + number % 10;
        number = number / 10;
        if (number == 0)
        {
            break;
        }
    }
    return sum;
}

void PrintReport(int number)
{
    Console.WriteLine($"Сумма цифр в числе {numb} равняется -> {number}");
}