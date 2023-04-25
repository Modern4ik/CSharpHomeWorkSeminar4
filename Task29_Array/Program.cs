// Программа , которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int minValue = GetMinValueFromUser("Введите минимальное значение массива: ", "Ошибка ввода.Повторите попытку!");
int maxValue = GetMaxValueFromUser("Введите максимальное значение массива: ", "Ошибка ввода.Повторите попытку!");

int[] array = GetArray(minValue, maxValue);

PrintArray(array);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int GetMinValueFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int number1))
            return number1;
        Console.WriteLine(errorMessage);
    }
}

int GetMaxValueFromUser(string message, string errorMessage)
{
while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int number2))
            return number2;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int number1, int number2)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(number1, number2 + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
}