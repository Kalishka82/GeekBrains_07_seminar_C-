// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.)

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.WriteLine($"Sum of main diagonal elements: {FindMainDiagonalSums(numbers, height, width)}");

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


int FindMainDiagonalSums(int[,] numbers, int height, int width)
{
    int sum = 0;

    for (int i = 0; i < height && i < width; i++)
    {
        sum += numbers[i, i]; // O(n)
    }
    return sum;
}

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
