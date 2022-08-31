/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] Order(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int k = 0; k < matr.GetLength(1); k++)
        {
            int min = matr[i, 0];
            int max = matr[i, 0];
            for (int j = 1; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] > max)
                {

                    int help = matr[i, (j - 1)];
                    matr[i, (j - 1)] = matr[i, j];
                    matr[i, j] = help;
                    max = matr[i, j];
                }
                else
                {
                    if (matr[i, j] < min)
                    {
                        min = matr[i, j];
                    }
                    else
                    {
                        int help = matr[i, j];
                        matr[i, j] = matr[i, (j - 1)];
                        matr[i, (j - 1)] = help;

                    }
                }

            }

        }
    }
    return matr;
}


int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Order(matrix);
PrintArray(matrix);

//Задачка заставляет думать, основная проблема была в правильной расстановке (int max,min), пришлось помучаться:).

