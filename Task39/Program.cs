/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] ArrayCreation(int length) //метод, заполняющий массив случайными числами
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

int findMin(int[] array)
{
    int minimum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minimum)
            minimum = array[i];
    }
    return minimum;

}

int findMax(int[] array)
{
    int maximum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maximum)
            maximum = array[i];
    }
    return maximum;
}


void PrintArray(int[] array) // метод, выводящий массив в консоль
{
    foreach (int item in array)
        Console.Write($"{item} ");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] array = ArrayCreation(length);


Console.WriteLine("Случайный массив:");
PrintArray(array);

int minimum = findMin(array);

int maximum = findMax(array);

int result = maximum - minimum;

Console.WriteLine();
Console.WriteLine($"Разность между максимальным значением  {maximum} и минимальным  {minimum} равна {result}");