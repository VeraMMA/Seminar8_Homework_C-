static void Print(string word)
{
    System.Console.WriteLine(word);
}
Print("Упорядочить в порядке убывания элементы каждой строки двумерного массива.");

void FillMatrix(int[,] matr)
{
    Random rand = new Random();

    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = rand.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    Print("Печать массива.");
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]}\t");
        }
        System.Console.WriteLine();
    }
}

void SortToMin(int[,] matr)
{
    int temp;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[rows, columns] > matr[rows, k])
                {
                    temp = matr[rows, columns];
                    matr[rows, columns] = matr[rows, k];
                    matr[rows, k] = temp;
                }
            }
        }
        System.Console.WriteLine();
    }
}

void PrintMatrixToMin(int[,] matr)
{
    Print(" Печать в порядке убывания элементов каждой строки массива.");
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            Console.Write($"{matr[rows, k]}\t");
        }
        System.Console.WriteLine();
    }
}

int m = 3;
int n = 4;

int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
SortToMin(matrix);
PrintMatrixToMin(matrix);

