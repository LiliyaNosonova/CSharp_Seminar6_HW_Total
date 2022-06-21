
// Частотный словарь целочисленной матрицы

// Метод задания целочисленного двумерного массива (матрица)
void FillMultiArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMultiArray(int[,] matr)// Метод вывода многомерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++) //matrix.GetLength(0) - количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)// matrix.GetLength(1) - количество столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();// Для вывода массива в виде таблицы 3*4
    }
}

// Метод сортировки целочисленного одномерного массива

void SortSelection(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPos]) MinPos = j;
        }
        int temp = array[i];
        array[i] = array[MinPos];
        array[MinPos] = temp;
    }
}

// Метод подсчета количества одинаковых чисел в целочисленноv одномерном массиве
void WordBook(int[] arr)
{
    double col = 1;
    // percent = Math.Round (col * 100 / arr.Length);
    double percent = Math.Round((col * 100 / arr.Length), 2);
    for (int k = 0; k < arr.Length; k++)
    {
        if (k != arr.Length - 1)
        {
            if (arr[k] == arr[k + 1])
            {
                col++;
                percent = Math.Round((col * 100 / arr.Length), 2);
            }
            else
            {
                System.Console.WriteLine($"Число: {arr[k]}; встречается раз: {col}; частота: {percent}%");
                col = 1;
                percent = Math.Round((col * 100 / arr.Length), 2);

            }

        }
        else
        {

            System.Console.WriteLine($"Число: {arr[k]}; встречается раз: {col}; частота: {percent}%");
        }
    }
}

void PrintNewArray(int[] Arr2)
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
    }
}

int[] MatrixToArray(int[,] Matrix)
{
    int[] array = new int[Matrix.GetLength(0) * Matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {

        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            array[k] = Matrix[i, j];
            k++;
        }
    }
    return array;
}

int[,] RealMatrix = new int[3, 4];
FillMultiArray(RealMatrix);
System.Console.WriteLine();
PrintMultiArray(RealMatrix);
System.Console.WriteLine();
int[] RealArray = MatrixToArray(RealMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Массив из матрицы:");
PrintNewArray(RealArray);
SortSelection(RealArray);
System.Console.WriteLine();
System.Console.WriteLine("Массив после сортировки:");
PrintNewArray(RealArray);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Частотный словарь заданного целочисленного массива:");
WordBook(RealArray);











