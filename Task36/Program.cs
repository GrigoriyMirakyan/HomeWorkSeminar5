/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] ArrayCreation(int length) //метод, заполняющий массив случайными числами, двухзначными
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-99, 100);
    }
    return arr;
}

int GetSummsUnevenFromArray1(int[] arr) // метод, складывающий элементы с нечетными индексами
{
    int summ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            summ += arr[i];
    }

    return (summ);
}

int GetSummsUnevenFromArray2(int[] arr) // метод, складывающий элементы стоящих на нечетных позициях
{
    int summ = 0;

    for (int j = 0; j < arr.Length; j++)
    {
        if (j % 2 == 0)
            summ += arr[j];
    }

    return (summ);
}

void PrintArray(int[] arr) // метод, выводящий массив в консоль
{
    foreach (int item in arr)
        Console.Write($"{item} ");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = ArrayCreation(length);


Console.WriteLine("Случайный массив:");
PrintArray(arr);

int result1 = GetSummsUnevenFromArray1(arr);

Console.WriteLine();
Console.WriteLine($"Сумма элементов, с нечетными индексами равна {result1}  ");

int result2 = GetSummsUnevenFromArray2(arr);

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях {result2}  ");