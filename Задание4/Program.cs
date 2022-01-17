// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = new int [10];
int Sum = 0;
int i = 0;
for (i = 0; i < array.Length; i++ )
{
    Console.Write($"Введите элемент {i + 1} массива: ");
    array[i] = int.Parse(Console.ReadLine()??"0");
}
Console.WriteLine("Массив: ");
for (i = 0; i < array.Length; i++ )
{
   Console.Write($"{array[i]} "); 
}
for (i = 0; i < array.Length; i+=2)
{

    Sum = Sum + array[i];
}
Console.WriteLine($"Сумма чисел стоящих на нечетной позиции = {Sum}");