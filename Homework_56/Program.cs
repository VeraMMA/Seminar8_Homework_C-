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
            Print("Найдите строку c наименьшей суммой элементов.");

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

             void MaxRow(int [,] matr)
            {  Print("Сумма элементов в каждой строке");
                 for (int rows = 0; rows < matr.GetLength(0); rows++)
                {     Double summa = 0;
                    for (int columns = 0; columns < matr.GetLength(1); columns++)
                    {
                       summa = summa + matr[rows, columns];
                    }
                    System.Console.WriteLine(summa);

                }   

            }

             int [,] matrix = new int [4, 4];
             
              FillMatrix(matrix);
              PrintMatrix(matrix);
              MaxRow(matrix);
              
        

