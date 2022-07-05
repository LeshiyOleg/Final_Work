
string[] FillStringArray(int arrayLength)
{
    string[] arrayToFill = new string[arrayLength];
    Console.WriteLine($"Поочередно введите {arrayLength} строковых элементов массива. После ввода каждого элемента нажмите клавишу ENTER.");
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        arrayToFill[i] = Console.ReadLine();
    }
    return arrayToFill;
}

string[] GetMaxThreeSymbElemArray(string[] arrayToExtract)
{
    int resultSize = 0;
    for (int i = 0; i < arrayToExtract.Length; i++)
    {
        if (arrayToExtract[i].Length <= 3)
        {
            resultSize += 1;
        }
    }
    string[] resultArray = new string[resultSize];
    int j = 0;
    for (int i = 0; i < arrayToExtract.Length; i++)
    {
        if (arrayToExtract[i].Length <= 3)
        {
            resultArray[j] = arrayToExtract[i];
            j += 1;
        }
    }
    return resultArray;
}

void PrintArray(string[] arrayToPrint)
{
    if (arrayToPrint.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < arrayToPrint.Length - 1; i++)
        {
            Console.Write($"\"{arrayToPrint[i]}\", ");
        }
        Console.WriteLine($"\"{arrayToPrint[arrayToPrint.Length - 1]}\"]");
    }
    else
    {
        Console.WriteLine("[]");
    }
}

Console.Write("Введите количество строковых элементов в массиве: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
string[] array = FillStringArray(lengthArray);
Console.WriteLine();
Console.Write("Заданный массив: ");
PrintArray(array);
string[] maxThreeSymbArray = GetMaxThreeSymbElemArray(array);
Console.Write("Массив с элементами менее либо равными 3 символам: ");
PrintArray(maxThreeSymbArray);
