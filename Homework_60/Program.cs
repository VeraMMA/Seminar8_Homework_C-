
static void Print(string word)
{
    System.Console.WriteLine(word);
}
Print("Построчно вывести массив из неповторяющихся двузначных чисел, добавляя индексы каждого элемента");
void FillMatrix(int[,,] matr)
{
    Print("Заполните массив неповторяющимеся двузначными числами");
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int col = 0; col < matr.GetLength(1); col++)
            {
                matr[rows, columns, col] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

void PrintElement(int[,,] matr)
{Print("Вывод массива и индексов каждого элемента");
    bool find = false;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int col = 0; col < matr.GetLength(1); col++)
            {
                foreach (int item in matr)
                {
                    if (matr[rows, columns, col] == item)
                       {
                        Console.Write($"{item} - ({rows}),({columns}),({col})\t");
                        find = true;
                       } 
                }  Console.WriteLine();
            }
        } 
    } Console.WriteLine();
} 
int[,,] matrix = new int[2, 2, 2];

FillMatrix(matrix);
PrintElement(matrix);
