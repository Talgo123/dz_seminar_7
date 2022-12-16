//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void TrueFalse(int[,] arr, int digit)
{
    bool res = false;
    int i = 0;
    int j = 0;
    for (i = 0; i < arr.GetLength(0); i++)
    {
        for (j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == digit)
            {
                res = true;
                Console.WriteLine($"Число {digit} находится под индексом {i},{j}");
            }
        }
    }
    if (res)
    {
        Console.WriteLine();
        
    }
    else
    {
        Console.WriteLine($"Число {digit} в массиве нет");
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNUmber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Получить от пользователя M и N.
int m = EnterNUmber("Введите значение M: ");
int n = EnterNUmber("Введите значение N: ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
ShowArray(matrix);
int number = EnterNUmber("Введите число для его поиска в массиве: ");
TrueFalse(matrix, number);





