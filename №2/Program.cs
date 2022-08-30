/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


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

int[] StringSum(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int stringsum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            stringsum += matr[i, j];
            array[i] = stringsum;
        }
    }
    return array;
}

void Sum(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == min)
        {
            Console.WriteLine("Строка с наименьшей суммой элементов: " + (i+1));
        }
    }
}

int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Sum(StringSum(matrix));

/* По какой-то причине данная задача взорвала мне мозг, но все-таки удалось ее решить добавив посленюю проверку в функции(Sum). ушло 2.5+ часа. */
