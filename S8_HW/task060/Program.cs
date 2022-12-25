/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using static UserMethods.Method;
Random rnd = new Random();

int[,,] genArray = Generated3dArray();
Print3dArray(genArray);


//генерация трёхмерного массива
int[,,] Generated3dArray()
{
    int rows = rnd.Next(2, 3);
    int columns = rnd.Next(2, 3);
    int levels = rnd.Next(2, 3);
    int rndNum = 0;
    int[,,] array = new int[rows, columns, levels];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                rndNum = rnd.Next(10, 100);
                if (EqualRandomNumbersIn3dArray(array, rndNum) == false) k--;
                else array[i, j, k] = rndNum;
            }
        }
    }
    return array;
}
//печать трёхмерного массива 
void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} [{i},{j},{k}]" + "\t");
            }
        }
        Console.WriteLine();
    }
}

//проверка элементов трёхмерного массива на уникальность
bool EqualRandomNumbersIn3dArray(int[,,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (num == arr[i, j, k])
                    return false;
            }
        }
    }
    return true;
}
