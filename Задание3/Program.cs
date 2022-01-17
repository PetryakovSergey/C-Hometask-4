// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int [123];
int number = 0;
for (int i = 0; i < array.Length; i ++)
{
    if ((i > 9) && (i < 100))
    {
        number = number + 1;
    }
}

Console.WriteLine($"В одномерном массиве из 123 чисел количество элементов из отрезка [10,99] = {number}");