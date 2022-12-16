// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


void ShowArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double[,] array = new double [rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = new Random().NextDouble() *  (rightRange - leftRange) + leftRange;;
           array[i, j] = Math.Round(array[i, j], 2);
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

// Создать двумерный массив.
double[,] matrix = CreateRandomArray(m, n, -10, 10);

// Вывести.
ShowArray(matrix);
