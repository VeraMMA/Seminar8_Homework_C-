// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

static void Print(string word)
{
    System.Console.WriteLine(word);
}

void FillMatrix(int[,,] matr)
{
    Print("Построчно вывести массив из неповторяющихся двузначных чисел, добавляя индексы каждого элемента");
    Random rand = new Random();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int col = 0; col < matr.GetLength(1); col++)
            {

                matr[rows, columns, col] = rand.Next(1, 100);

            }


        }
    }
}

void PrintMatrix(int[,,] matr)
{
    Print("Вывод массива");
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int col = 0; col < matr.GetLength(1); col++)
            {
                Console.Write($"{matr[rows, columns, col]}\t");

            }
             System.Console.WriteLine();
        }
       
    }
}




int[,,] matrix = new int[2, 2, 2];

FillMatrix(matrix);
PrintMatrix(matrix);
