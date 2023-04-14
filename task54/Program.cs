﻿/* Задача 54: 
Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  */ 

int[,] array= new int[3, 4];
for ( int i = 0; i < array.GetLength(0); i++)
{
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j]= new Random(). Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

for ( int i = 0; i < array.GetLength(0); i++)
{
    List<int> list = new List<int>();
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        list.Add(array[i, j]);
    }
    list.Sort();
    list.Reverse();
    for ( int j = 0; j < array.GetLength(1); j++) array[i, j] = list[j];
}

Console.WriteLine();

for ( int i = 0; i < array.GetLength(0); i++)
{
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}