// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 0 строка
static void Print(string word)
        {
            System.Console.WriteLine(word);
        }
            Print("Найдите среднее арифметическое элементов в каждом столбце.");

        void FillMatrix(int [,] matr)
        { Print("Заполните массив целыми числами");
            Random rand = new Random();
            for (int rows = 0; rows < matr.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matr.GetLength(1); columns++)
                {

                    matr[rows, columns] = rand.Next(1, 10);

                }
            }
        }

            void PrintMatrix(int [,] matr)
            { Print("Вывод массива");
                for (int rows = 0; rows < matr.GetLength(0); rows++)
                {
                    for (int columns = 0; columns < matr.GetLength(1); columns++)
                    {
                        Console.Write($"{matr[rows, columns]}\t");

                    }
                    System.Console.WriteLine();
                }   
            }

          void SumMatrix(int [,] matr)
            {  Print("Среднее арифметическое каждого столбца");
                 for (int rows = 0; rows < matr.GetLength(1); rows++)
                {     Double summa = 0;
                    for (int columns = 0; columns < matr.GetLength(0); columns++)
                    {
                       summa = summa + matr[columns, rows];
                    }
                     Double sumOfCol = summa/matr.GetLength(0);
                        sumOfCol = Math.Round(sumOfCol, 1);
                    System.Console.WriteLine(sumOfCol);
                }   
            }


             int [,] matrix = new int [3, 4];
             
              FillMatrix(matrix);
              PrintMatrix(matrix);
              SumMatrix(matrix);
                
        

