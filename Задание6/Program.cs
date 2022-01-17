/* В Указанном массиве вещественных чисел 
найдите разницу между максимальным и минимальным элементом*/
double [] EnterArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = (new Random()).Next(0, 11400) / 1000.0;
    }
    return array;
}

void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
}

double FindMax(double[] MaxArray)
{
    double Max = MaxArray[0];
    for (int i = 1; i < MaxArray.Length; i++)
    {
        if (MaxArray[i] > Max)
            Max = MaxArray[i];
    }
    return Max;
}

double FindMin(double[] MinArray)
{
    double Min = MinArray[0];
    for (int i = 1; i < MinArray.Length; i++)
    {
        if (MinArray[i] < Min)
            Min = MinArray[i];
    }
    return Min;
}

Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine() ??"0");
double [] ResultArray = EnterArray(N);
PrintArray(ResultArray);
double max = FindMax(ResultArray);
Console.WriteLine();
Console.WriteLine($"Максимальный элемент равен {max}");
double min = FindMin(ResultArray);
Console.WriteLine($"Минимальный элемент равен {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом составляет: {max - min}");