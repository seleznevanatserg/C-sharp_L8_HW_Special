/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static UserMethods.Method;

int[,] genArray1 = GeneratedRandom2dArray();
int[,] genArray2 = GeneratedRandom2dArray();
Console.WriteLine("First matrix");
Print2dGenArray(genArray1);
Console.WriteLine();
Console.WriteLine("Second matrix");
Print2dGenArray(genArray2);

if (genArray1.GetLength(1) != genArray2.GetLength(0)) // Проверка на равенство длине столбца первого массива длине строки второго массива.
{
    Console.WriteLine($"Columns ({genArray1.GetLength(1)}) first matrix not equal Rows ({genArray2.GetLength(0)}) second matrix");
}
else
{
    int[,] prodArray = ProductedMatrix(genArray1, genArray2);
    Console.WriteLine();
    Console.WriteLine("Produced matrix");
    Print2dGenArray(prodArray);
}

// Метод перемножения матриц
// Поскольку массивы рандомные (см. Class1.cs), то придётся немного покрутить чтобы столбец первого совпал со строкой второго.
int[,] ProductedMatrix(int[,] arr1, int[,] arr2)
{
    int[,] arrP = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arrP.GetLength(0); i++)
    {
        for(int j = 0; j < arrP.GetLength(1); j++)
        {
            int sum = 0;
            for(int k = 0; k < arr1.GetLength(1); k++)
            {
                sum = sum + arr1[i,k] * arr2[k,j];
            }
            arrP[i,j] = sum;
        }
    }
    return arrP;
}