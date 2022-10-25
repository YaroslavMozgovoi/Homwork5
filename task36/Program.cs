// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size) //Создание массива
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(10, 99);
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

void SumAddAlement(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
} 

int[] createArray = CreateArray(20);
PrintArray(createArray);
SumAddAlement(createArray);