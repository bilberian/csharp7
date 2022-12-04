// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

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
    if (matrix[i,j] == number) result = true;
}

if(result) { Console.WriteLine($"Найдено ваше число {number}"); }
else { Console.WriteLine($"{number} => такого числа в массиве нет"); }
