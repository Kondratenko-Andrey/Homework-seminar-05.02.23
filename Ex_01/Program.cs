// Составить частотный словарь элементов двумерного массива

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

Console.Write("Введите необходимое кол-во строк в матрице: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите необходимое кол-во столбцов в матрице: ");
int n = int.Parse(Console.ReadLine()!);

int[,] arr = new int[m, n];

Console.WriteLine("Ниже предоставлена сформированная матрица:");

FillArr(arr);
PrintArr(arr);

int[] a = new int[(m*n)];

int count = 0;

for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            a[count] = arr[i, j];
            count++;
        }

    }

Console.WriteLine();

for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < a.Length - 1 - i; j++)
    {
        if (a[j] > a[j + 1])
        {
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
        }
    }
}

count = 1;
int temp2 = 1;


for (int i = 0; i < a.Length; i = i + temp2)
{
    temp2 = 1;
    for (int j = i + 1; j < a.Length; j++)
    {
        if (a[i] == a[j])
        {
            count++;
            temp2 = count;
        }
        else break;

    }

    Console.WriteLine($"{a[i]} встречается {count} раз");
    count = 1;
}