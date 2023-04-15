/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int VariableCreate (string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    return int.Parse(Console.ReadLine());
}

double[,] CreateMatrix(int m, int n, int Min, int Max)
{
    double [,] Array = new double [m,n];
    Random x = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = Convert.ToDouble(x.Next(Min*100, Max*100)/100.0);
            
        }
    }
    return Array;
}

void PrintMatrix(double [,] Array)
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
/*---------------------------------------------------------------------------------------*/

int m = VariableCreate("коэффициент размерности m:");
int n = VariableCreate("коэффициент размерности n:");
int Min = VariableCreate("нижний предел массива:");
int Max = VariableCreate("верхний предел массива:");

double[,] Array = CreateMatrix(m,n, Min, Max);
PrintMatrix(Array);
