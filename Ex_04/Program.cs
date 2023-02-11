// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

bool SameElements(int[,,] arr, int element)
{
    int count = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int g = 0; g < arr.GetLength(2); g++)
            {
                if (arr[i, j, g] == element) count ++;
                if (count > 1) return true;
            }
        }
    }
    return false;

}

void FillArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int g = 0; g < arr.GetLength(2); g++)
            {
                
                arr[i, j, g] = new Random().Next(10, 100);
                
                while (SameElements(arr, arr[i, j, g]))
                {
                    arr[i, j, g] = new Random().Next(10, 100);
                }
            }
        }
    }

}

void PrintArr(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int g = 0; g < arr.GetLength(2); g++)
            {
                Console.Write($"arr[{i},{j},{g}] = {arr[i, j, g]} ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите o: ");
int o = int.Parse(Console.ReadLine()!);

int[,,] arr = new int[m, n, o];

Console.WriteLine("Ниже предоставлен сформированный трехмерный массив:");

FillArr(arr);
PrintArr(arr);