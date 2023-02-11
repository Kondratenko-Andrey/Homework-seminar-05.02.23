// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }

        Console.WriteLine();
    }
}

Console.Write("Введите необходимое кол-во строк в матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в матрице: ");
int n = int.Parse(Console.ReadLine()!);

int[,] arr = new int[m, n];

Console.WriteLine("Ниже предоставлена сформированная матрица:");

FillArr(arr);
PrintArr(arr);

int minRow = 0;
int minColumn = 0;

int minElement = arr[0, 0];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] < minElement)
        {
            minRow = i;
            minColumn = j;
            minElement = arr[i, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Минимальный элемент в матрице имеет индексы [{minRow}, {minColumn}] и равен {minElement}");

Console.WriteLine();

int[,] newArr = new int[(m - 1), (n - 1)];

for (int i = minRow; i < arr.GetLength(0) - 1; i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = arr[(i + 1), j];
    }

}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = minColumn; j < arr.GetLength(1) - 1; j++)
    {
        arr[i, j] = arr[i, (j+1)];
    }

}

for (int i = 0; i < newArr.GetLength(0); i++)
{
    for (int j = 0; j < newArr.GetLength(1); j++)
    {
        newArr[i, j] = arr[i, j];
    }

}

Console.WriteLine("После удаления строки и столбца, на пересечении которых расположен наименьший элемент, матрица имеет вид:");
Console.WriteLine();
PrintArr(newArr);