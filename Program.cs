﻿// Задача 34:Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/* int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] GenerateRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish);   
    }
    return array;
}
int[]array = GenerateRandomArray(4, 100, 1000);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($"Amount of even numbers -> {CountEven(array)}"); */


﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* int GetSumOfOddIn(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

int[] RandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start, finish + 1);
    }
    return array;
}

int[] array = RandomArray(7, -10, 10);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine($" = {GetSumOfOddIn(array)}"); */



// Задача 38:Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/* 
double GetMaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    Console.Write($" => {max} - {min}");
    return Math.Round(diff,2);
}

double[] GenerateRandomArray(int elements, double start, double finish)
{
    double[] array = new double[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = Math.Round((start + new Random().NextDouble()*(finish-start)),2);
    }
    return array;
}

double[] array = GenerateRandomArray(5, 0, 100);
Console.Write($"[{String.Join("; ", array)}]");
Console.WriteLine($" = {GetMaxMinDiff(array)}"); 
 */

