/* Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */

int[,] array = new int[4, 4];
List<int> list = new List<int>();

for( int i = 0; i < 17; i++) list.Add(i+1);

for ( int j = 0; j < array.GetLength(1); j++) 
{
    array[0, j] = list[0];
    list.Remove(list[0]);
}
for (int i = 1; i < 4; i++)
{
    array[i, 3] = list[0];
    list.Remove(list[0]);
}

for (int j = 2; j >= 0; j--) 
{
    array[3, j] = list[0];
    list.Remove(list[0]);
}

for (int j = 2; j > 0; j--) 
{
    array[j, 0] = list[0];
    list.Remove(list[0]);
}
for ( int j = 1; j < 3; j++)
{
    array[1, j] = list[0];
    list.Remove(list[0]);
}

for (int j = 2; j > 0; j--) 
{
    array[2, j] = list[0];
    list.Remove(list[0]);
}

Print(array);

void Print(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]:d2} ");
        Console.WriteLine();
    }
}