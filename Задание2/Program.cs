/* Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных/четных чисел*/
Console.WriteLine("Введите разиер массива: ");
int arrayLength =int.Parse(Console.ReadLine()??"0");
int[] array = new int [arrayLength];
int result1 = 0;
int result2 = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100,1000);
}
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result1 = result1 + 1;
    }
    else
    {
        result2 = result2 + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел = {result1} ");
Console.WriteLine($"Колличество нечетных чисел = {result2} ");