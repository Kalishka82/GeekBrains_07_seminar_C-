using System;
// Console.Write ("Введите любое количество чисел:");
// string line = Console.ReadLine ()!;     // "11 12 13 14"
// string[] parts = line.Split (' ');     // "11", "12", "13", "14"
// int[] numbers = new int[parts.Length];
// for (int i = 0; i < numbers.Length; i++)
//     numbers[i] = int.Parse (parts[i]);

// Задача 46: Задайте двумерный массив размером m × n, заполненный случайными целыми 
// числами.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}


void Print2DArray(int[,] numbers, int height, int width)
{    
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
           Console.Write($"{numbers[i, j], 3} ");
        }
    Console.WriteLine();
    }
}


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

// float EnterFloat(string prompt)
// {
//     Console.Write(prompt);
//     return float.Parse(Console.ReadLine()!);
// }

