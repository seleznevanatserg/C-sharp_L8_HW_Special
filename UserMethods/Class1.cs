namespace UserMethods;
public class Method
{
    public static int InputIntNumberTryParse() // enter number type int
    {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);
        if (isParsed) return number;
        else return -1;
    }
    public static uint InputUIntNumberTryParse() // enter number type uint
    {
        bool isParsed = uint.TryParse(Console.ReadLine(), out uint number);
        if (isParsed) return number;
        else return 0;
    }

    public static double InputDoubleNumberTryParse() // enter number type double
    {
        bool isParsed = double.TryParse(Console.ReadLine(), out double number);
        if (isParsed) return number;
        else return -1;
    }

    public static int[] CreatedArrayUserEntered(int enteredNumber) // create 1d array with using enter
    {
        int[] array = new int[enteredNumber];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter [{i + 1}] number: ");
            array[i] = InputIntNumberTryParse();
        }
        return array;
    }

    public static int[] GenerateArray(int min, int max, int length) // create 1d array with random
    {
        Random random = new Random();
        int[] array = new int[length];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    public static int[,] CreatedRandom2dArray(uint countOfRows, uint countOfColumns) // create 2d array with random
    {
        Random rnd = new Random();
        int[,] array = new int[countOfRows, countOfColumns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(-10, 11);
            }
        }
        return array;
    }

    // Генерация 2d массива с раномными строками/столбцами и значениями
     public static int[,] GeneratedRandom2dArray()
    {
        Random rnd = new Random();
        int rows = rnd.Next(2, 3);
        int columns = rnd.Next(3, 5);
        int[,] array = new int[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rnd.Next(-20, 21);
            }
        }
        return array;
    }

    public static void PrintArray(int[] array) // Print 1d array
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write($"[{array[i]}] ");
        }
        Console.WriteLine();
    }

    public static void PrintArray(double[] array) // Print 1d array with datatype DOUBLE
    {
        for (var i = 0; i < array.Length; i++)
        {
            Console.Write($"[{array[i]}] " + "\t");
        }
        Console.WriteLine();
    }

    // Печать массива
     public static void Print2dGenArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"[{array[i, j]}]" + "\t");
            }
            Console.WriteLine();
        }
    }

    public static void Print2dArrayDouble(double[,] array) // Print 2d array with datatype DOUBLE
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"[{array[i, j]}] " + "\t");
            }
            Console.WriteLine();
        }
    }

}
