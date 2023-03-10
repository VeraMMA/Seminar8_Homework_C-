// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
                    temp = matr [rows, columns];
                    matr[rows, columns] = matr[rows, k];
                    matr [rows, k] = temp;
                }

            }


        }
        System.Console.WriteLine();
    }
}


int[,] matrix = new int[3, 4];

FillMatrix(matrix);
PrintMatrix(matrix);
SortToMin(matrix);

