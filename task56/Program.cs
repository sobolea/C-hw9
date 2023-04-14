/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
 строки с наименьшей суммой элементов: 1 строка */


int[,] array= new int[4, 4];
for ( int i = 0; i < array.GetLength(0); i++)
{
    for ( int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j]= new Random(). Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

List<int> list = new List<int>();

for ( int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for( int j = 0; j < array.GetLength(1); j++)
    {     
        sum += array[i, j];
    }
    list.Add(sum);
}

int min = list[0];
int index = 0;
for( int i = 1; i < list.Count; i++)
{
    if( list[i] < min)  
    {
        min = list[i];
        index = i + 1;
    }
}
for( int i = 0; i < list.Count; i++) Console.Write($"{list[i]} ");
Console.WriteLine();
Console.WriteLine($"{index} строка");

