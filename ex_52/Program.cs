// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

using System;

int[,] numbers = new int[4, 4];
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine("-----");
PrintSumsArray(SumColumnElements(numbers));


void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}


void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j], 2} ");
        }
        Console.WriteLine();
    }
}


int[] SumColumnElements(int[,] numbers)
{
    int[] sums = new int[numbers.GetLength(1)];

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sums[j] = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sums[j] += numbers[i,j];
        }
    }
    return sums;
}


void PrintSumsArray(int[] sums)
{
    foreach (int sum in sums)
        Console.Write($"{sum, 2} ");
}
