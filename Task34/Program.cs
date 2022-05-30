/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] ArrayCreation(int length) //метод, заполняющий массив случайными положительными трёхзначными числами
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int findEven(int[] arr) // метод, подсчитывающий количество четных чисел
{
    int count = 0;

    foreach (int item in arr)
    {
        if (item % 2 == 0)
            count++;
    }

    return count;
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

int result = findEven(arr);
Console.WriteLine();
Console.WriteLine($"В данном массиве есть {result} четных чисел/числа");

