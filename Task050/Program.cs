/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int VariableCreate (string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    return int.Parse(Console.ReadLine());
}

int[,] CreateMatrix(int m, int n, int Min, int Max)
{
    int [,] Array = new int [m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(Min,Max);
            
        }
    }
    return Array;
}

void PrintMatrix(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write(Array[i,j]+" ");
        }
        System.Console.WriteLine();
    }
}

void FindElement(int [,] Array)
{
    int Element = 0;
    System.Console.WriteLine("Введите строку m для поиска элемента:");
    int mValue = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите столбец n для поиска элемента:");
    int nValue = int.Parse(Console.ReadLine());
    if (mValue>=Array.GetLength(0) || nValue>=Array.GetLength(1) || mValue<0 || nValue<0) 
    {
        System.Console.WriteLine($"Элемента с [{mValue};{nValue}] в данной матрице не существует.");
    }
    else System.Console.WriteLine($"Элемент с координатами [{mValue};{nValue}] - {Array[mValue,nValue]}.");

    
}
/*---------------------------------------------------------------------------------------*/

int m = VariableCreate("коэффициент размерности m:");
int n = VariableCreate("коэффициент размерности n:");
int Min = VariableCreate("нижний предел массива:");
int Max = VariableCreate("верхний предел массива:");
System.Console.WriteLine();

System.Console.WriteLine("Задана матрица:");
System.Console.WriteLine();

int[,] Array = CreateMatrix(m,n, Min, Max);
PrintMatrix(Array);
System.Console.WriteLine();


FindElement(Array);