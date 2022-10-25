// Задача 34:
//  Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int size) //Создание массива
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array) //Вывод массива на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int CollEvenNumbers(int[] array)
{
    int coll = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) coll = coll + 1;
    }
    return coll;
}

int[] createArray = CreateArray(20);
PrintArray(createArray);
int coll = CollEvenNumbers(createArray);
Console.WriteLine($"Количество чётных чисел в массиве = {coll}");
