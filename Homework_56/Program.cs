Print("Найдите строку c наименьшей суммой элементов.");

int m = 4;
int n = 4;   
int[,] matrix = new int[m, n];

FillMatrix(matrix);
PrintMatrix(matrix);
 
static void Print(string word)
{
    System.Console.WriteLine(word);
}

void FillMatrix(int[,] matr)
{
    Print("Заполнение массива целыми числами");
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
    Print("Вывод массива");
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]}\t");
        }
        System.Console.WriteLine();
    }
}

int SummRow(int[,] matr, int rows)
{
  int sumLine = matr[rows, 0];
  for (int columns = 1; columns < matr.GetLength(1); columns++)
  {
    sumLine += matr[rows,columns];
  }
  return sumLine;
}

int minSumRow = 0;
int sumLine = SummRow(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SummRow(matrix, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    minSumRow = i;
  }
}
Console.WriteLine($"{minSumRow} - cтpoкa c наименьшей суммой элементов равной: {sumLine}");









