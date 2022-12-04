// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите позицию строки элемента: ");
int numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите позицию столбца элемента: ");
int numberJ = Convert.ToInt32(Console.ReadLine());

int m = 3;
int n = 4;

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0,10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

bool result = false;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    if (i == numberI && j == numberJ) result = true;
}

if(result) { Console.WriteLine($"Найдено ваше число {matrix[numberI,numberJ]}"); }
else { Console.WriteLine($"{numberI}{numberJ} => такого числа в массиве нет"); }
