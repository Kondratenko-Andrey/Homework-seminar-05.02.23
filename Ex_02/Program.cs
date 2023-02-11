// Найти произведение двух матриц

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] MultipArr(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    int rows = 0;
    int columns = 0;

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int g = 0; g < arr2.GetLength(0); g++)
            {
                resultArr[rows, columns] += arr1[i, g] * arr2[g, j];

            }

            columns ++;
            if(columns == arr2.GetLength(1)) columns = 0;
        }

        rows ++;
            if(rows == arr1.GetLength(0)) rows = 0;
    }

    return resultArr;
}

Console.Write("Введите необходимое кол-во строк в первой матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в первой матрице, которое равно кол-ву строк второй матрицы: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов во второй матрице: ");
int o = int.Parse(Console.ReadLine()!);

int[,] arr1 = new int[m, n];
int[,] arr2 = new int[n, o];

Console.WriteLine();

FillArr(arr1);
PrintArr(arr1);

Console.WriteLine();

FillArr(arr2);
PrintArr(arr2);

Console.WriteLine();

Console.WriteLine("Произведение данных матриц представлено ниже:");

Console.WriteLine();

int[,] arr3 = MultipArr(arr1, arr2);

PrintArr(arr3);