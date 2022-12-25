/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

using static UserMethods.Method;
Random rnd = new Random();

int[,] array = SpiralArray();
Print2dGenArray(array);

int[,] SpiralArray()
{

    int[,] arr = new int[4, 4];
    
    int limitRow = 0;
    int limitColumn = 0;
    int startRow = 0;
    int startColumn = 0;
    int r = 0;
    int c = 0;
    int count = 1;

    while (count <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[r,c] = count;

        if (r == startRow && c < arr.GetLength(1) - limitColumn - 1) c++; // right
        else 
        {
            if (c == arr.GetLength(1) - limitColumn - 1 && r < arr.GetLength(0) - limitRow - 1) r++; // down
            else 
            {
                if (r == arr.GetLength(0) - limitRow - 1 && c > startColumn) c--; // left
                else r--; // up
            }
        }
        //проверяет, что пришли в начало и не закончились ли столбцы
        if (r == startRow + 1 && c == startColumn && startColumn != arr.GetLength(1) - limitColumn - 1)
        {
            startRow++;
            limitRow++;
            startColumn++;
            limitColumn++;
        }
        count++;
    }
    return arr;
} 

       
     
  

 