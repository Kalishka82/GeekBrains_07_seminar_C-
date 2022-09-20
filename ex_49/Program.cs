// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и
//  замените эти элементы на их квадраты.
int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
Console.WriteLine();
Change2DArray(numbers, height, width);
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


void Change2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i+=2)
    {
        for (int j = 0; j < width; j+=2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
}

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
