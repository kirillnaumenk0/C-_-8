/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 9);
        }
    }
}


void Multiplication(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
           matr3[i,j] = matr1[i,j] * matr2[i,j];
        }
    }
}



int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] matrix3 = new int[2, 2];

FillArray(matrix1);
FillArray(matrix2);
FillArray(matrix3);
Console.WriteLine("Матрица №1: ");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица №2: ");
PrintArray(matrix2);
Console.WriteLine();
Multiplication(matrix1, matrix2, matrix3);
Console.WriteLine("Результирующая матрица: ");
PrintArray(matrix3);
Console.WriteLine();


//Не доконца понял пример к этому заданию, но сделал по условию, работает правильно.