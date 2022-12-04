// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Среднее арифметическое столбца: ");
double sum = 0;
double result = 0;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        sum += matrix[i, j];
    }
    result = Math.Round(sum / m, 1);
    Console.Write($"{result}; ");
    sum = 0;
}
