// ДЗ ЗАДАЧА 3. Показать треугольник Паскаля 
// *Сделать вывод в виде равнобедренного треугольника *Показать только нечетные числа в треугольнике


int size = 6;
int[,] array = new int[size, size];
array[0, 0] = 1;
// System.Console.Write(array[0, 0]);
for (int i = 1; i < size; i++)
{
    // System.Console.WriteLine();
    array[i, 0] = 1;
    // System.Console.Write($"{array[i, 0]}  |  ");
    for (int j = 1; j < size; j++)
    {
        array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        // System.Console.Write($"{array[i, j]}  |  ");
    }
}

int FindMax(int[,] arr1)
{
    int Max = arr1[0, 0];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[i, j] > Max)
            {
                Max = arr1[i, j];
            }
        }

    }
    return Max;
}

int max = FindMax(array);
// System.Console.WriteLine(max);
string max2 = max + "";
int LengthMax = max2.Length;
// System.Console.WriteLine(LengthMax);

for (int i = 0; i < size; i++)
{
    System.Console.WriteLine();
    for (int k = i; k < size; k++)
    {
        for (int x = 0; x < LengthMax; x++) System.Console.Write(" ");
    }
    for (int j = 0; j < size; j++)
    {
        if (array[i, j] % 2 == 0)
        {
            for (int x = 0; x < LengthMax; x++) System.Console.Write(" ");
        }
        else
        {
            if (array[i, j] > 0)
            {
                if (array[i, j] < max)
                {
                    int LengthElements = (array[i, j] + "").Length;
                    for (int x = LengthElements; x < LengthMax; x++) System.Console.Write("0");
                    System.Console.Write($"{array[i, j]}");
                }
                else
                {
                    System.Console.Write(array[i, j]);
                }
            }
        }
        for (int x = 0; x < LengthMax; x++) System.Console.Write(" ");
    }
}
