//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*int[,] FillNewMatrixMassiv(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,9);
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

void SortMasiv(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Напишите количество строк ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите количество столбцов ");
int columm = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int[,] matrix = FillNewMatrixMassiv(row,columm);
PrintMatrixMassiv(matrix);
Console.WriteLine();
SortMasiv(matrix);
PrintMatrixMassiv(matrix);*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int[,] FillNewMatrixMassiv(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(2,30);
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

void SummaRowMatrixMassiv(int[,] matrix)
{
    int minsumcolumn = 0;
    int mincolumn = 0;
    int sumcolumn = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        mincolumn += matrix[0, i];
    }
        for(int i=0; i<matrix.GetLength(0); i++)
        {
            for(int j=0; j<matrix.GetLength(1); j++)
                sumcolumn += matrix[i, j];
                    if(sumcolumn<mincolumn)
                    {
                    mincolumn=sumcolumn;
                    minsumcolumn = i;
                    }
            Console.Write($"{sumcolumn}\t ");
            sumcolumn = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов:{minsumcolumn+1} строка\t");
}

Console.Write("напишите количество столбцов ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк ");
int columm = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillNewMatrixMassiv(row,columm);
PrintMatrixMassiv(matrix);

Console.WriteLine("---------------------------");
SummaRowMatrixMassiv(matrix);*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
/*int[,,] FillNewMatrixMassiv(int row, int column, int depth)
{
    int[,,] matrix = new int[row, column, depth];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            for(int k =0; k<matrix.GetLength(1); k++)
                {
                    matrix[i,j,k] = rnd.Next(2,30);
                }
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int k=0; k<matrix.GetLength(2); k++)
                {
                    Console.Write($"{matrix[i,j,k]}{(i,j,k)}\t");
                }
        }
    Console.WriteLine();
    }
}

Console.Write("напишите количество столбцов ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк ");
int columm = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество глубины ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillNewMatrixMassiv(row,columm,depth);
PrintMatrixMassiv(matrix);*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3

/*int[,] FillNewMatrixMassivFist(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(2,30);
        }
    }
    return matrix;
}

void PrintMatrixMassivFist(int[,] matrixfirst)
{
    for(int i=0; i<matrixfirst.GetLength(0); i++)
    {
        for(int j=0; j<matrixfirst.GetLength(1); j++)
        {
            Console.Write($"{matrixfirst[i,j]}\t");
        }
    Console.WriteLine();
    }
}

int[,] FillNewMatrixMassivSecond(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(2,30);
        }
    }
    return matrix;
}

void PrintMatrixMassivSecond(int[,] matrixsecond)
{
    for(int i=0; i<matrixsecond.GetLength(0); i++)
    {
        for(int j=0; j<matrixsecond.GetLength(1); j++)
        {
            Console.Write($"{matrixsecond[i,j]}\t");
        }
    Console.WriteLine();
    }
}

void Multiplication(int[,] matrixfirst, int[,] matrixsecond, int[,] multiplication)
{
    for(int i=0; i<multiplication.GetLength(0); i++)
    {
        for(int j=0; j<multiplication.GetLength(1); j++)
        {
            int sum = 0;
                for(int k=0; k<matrixfirst.GetLength(1); k++)
                {
                    sum+=matrixfirst[i,k]*matrixsecond[k,j];
                }
            multiplication[i,j] = sum;
            Console.Write($"{multiplication[i,j]}\t");
        }
    }
    
}

Console.Write("напишите количество столбцов первого массива ");
int rowfirst = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк второго массива ");
int colummfirst = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество столбцов первого массива ");
int rowsecond = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк второго массива ");
int colummsecond = Convert.ToInt32(Console.ReadLine());
int[,] matrixfirst = FillNewMatrixMassivFist(rowfirst,colummfirst);
PrintMatrixMassivFist(matrixfirst);
Console.WriteLine();
int[,] matrixsecond = FillNewMatrixMassivSecond(rowsecond,colummsecond);
PrintMatrixMassivSecond(matrixsecond);
int[,] multiplication = new int[rowfirst, colummfirst];
Console.WriteLine("---------------------------");
Multiplication(matrixfirst, matrixsecond, multiplication);*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

/*int[,] FillNewMatrixMassiv(int row)
{
    int[,] matrix = new int[row, row];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= row * row)
            {
                matrix[i, j] = num;
                if (i <= j + 1 && i + j < row - 1)
                ++j;
                else if (i < j && i + j >= row - 1)
                ++i;
                else if (i >= j && i + j > row - 1)
                --j;
                else
                --i;
                ++num;
            }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

Console.Write("напишите длину массива ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillNewMatrixMassiv(row);
PrintMatrixMassiv(matrix);*/

//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] FillNewMatrixMassiv(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {
        for(int j =0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(2,30);
        }
    }
    return matrix;
}

void PrintMatrixMassiv(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
    Console.WriteLine();
    }
}

int[,] MinPositionElementMatrixMassiv(int[,] matrix, int[,] position)
{
    int minnum = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]<minnum)
            {
               position[0, 0] = i;
               position[0, 1] = j;
               minnum = matrix[i,j];
            }
        } 
    }
    Console.WriteLine($"Mинимальный элемент: {minnum}");
    return position;
}

void DeleteLines(int[,] matrix, int[,] position, int[,] matrixnew)
{
  int k = 0, l = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (position[0, 0] != i && position[0, 1] != j)
      {
        matrixnew[k, l] = matrix[i, j];
        l++;
      }
    }
    l = 0;
    if (position[0, 0] != i)
    {
      k++;
    }
  }
}

Console.Write("напишите количество столбцов ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("напишите количество строк ");
int columm = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillNewMatrixMassiv(row,columm);
PrintMatrixMassiv(matrix);
int[,] position = new int[1, 2];
position = MinPositionElementMatrixMassiv(matrix, position);
int[,] matrixnew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
DeleteLines(matrix, position, matrixnew);
Console.WriteLine("---------------------------");
PrintMatrixMassiv(matrixnew);



