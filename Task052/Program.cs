/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void FindAverage(int[,] Array)
{
    
    System.Console.Write("Среднее арифметическое столбцов: ");
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        double Average = 0;
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            Average += Array[j,i];
        }
        Average = Average/Array.GetLength(0);
        System.Console.Write(Average+", ");
    }
    
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

FindAverage(Array);

