/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20      1.0.0 * 2.0.0 + 1.0.1 * 2.1.0   1.0.0 * 2.0.1 + 1.0.1 * 2.1.1
15 18      1.1.0 * 2.0.0 + 1.1.1 * 2.1.0   1.1.0 * 2.0.1 + 1.1.1 * 2.1.1 */

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] arrayRes= new int[2, 2];

List<int> list1 = new List<int>();
List<int> list2 = new List<int>();

FillArray(array1);
Print(array1);
Console.WriteLine();
FillArray(array2);
Print(array2);
Console.WriteLine();

AddToList(array1, list1);
AddToList(array2, list2);

arrayRes[0,0] = list1[0] * list2[0] + list1[1] * list2[2];
arrayRes[0,1] = list1[0] * list2[1] + list1[1] * list2[3];
arrayRes[1,0] = list1[2] * list2[0] + list1[3] * list2[2];
arrayRes[1,1] = list1[2] * list2[1] + list1[3] * list2[3];

Print(arrayRes);

void FillArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(5);
    }
}

void Print(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void AddToList(int[,] array, List<int> list)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++) list.Add(array[i, j]);

    }
}