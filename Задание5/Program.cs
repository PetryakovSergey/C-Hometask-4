/* Найти произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/
int [] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,11);
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]} ");
    }
}

int[] result(int[] numbers)
{
    int length = numbers.Length / 2;
    if (numbers.Length % 2 == 0)
    {
       int[] newArray = new int[length]; 
       for (int i = 0; i < length; i++)
       {
            newArray[i] = numbers[i]*numbers[numbers.Length - 1 - i];
       }
       return newArray; 
    }
    else
    {
        int[] newArray = new int[length+1];
        for (int i = 0; i <= length; i++)
        {
            newArray[i] = numbers[i]*numbers[numbers.Length - 1 - i];
        }
        return newArray; 
    }
    
}
Console.Write($"Введите длину массива: ");
int N = int.Parse(Console.ReadLine() ??"0");
int [] ResultArray = EnterArray(N);
Console.WriteLine($"Заданный массив: ");
PrintArray(ResultArray);
Console.WriteLine();
Console.Write($"Произведение пар чисел массива: ");
int[] conclusionArray = result(ResultArray);
PrintArray(conclusionArray);