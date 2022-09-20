// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится
//  по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int height = EnterInt("Enter height: ");
int width = EnterInt("Enter width: ");
// int height = 10;
// int width = 10;

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = i + j;
        }
    }
}


void Print2DArray(int[,] numbers, int height, int width)
{    
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
        Console.Write($"{numbers[i,j]} ");
        //    Console.Write($"{i} x {j} = {numbers[i, j], 2}   ");
        }
    Console.WriteLine();
    }
}


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}