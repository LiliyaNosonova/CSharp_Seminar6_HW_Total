// ДЗ ЗАДАЧА 2. Найти произведение двух матриц

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

int[,] ProductMultiArray(int[,] matrix11, int[,] matrix22)
{
    int[,] matrix = new int[matrix11.GetLength(0), matrix22.GetLength(1)];
    for (int x = 0; x < matrix11.GetLength(0); x++)
    {
        for (int y = 0; y < matrix22.GetLength(1); y++)
        {
            matrix[x, y] = 0;
            for (int k = 0; k < matrix11.GetLength(1); k++)
            {
                matrix[x, y] = matrix[x, y] + matrix11[x, k] * matrix22[k, y];
            }
        }
    }
    return (matrix);
}

//Ручное задание матриц
// int[,] matrix1 = new int[,]
// {
//     {1,2,3,1},
//     {4,5,6,2},
//     {7,8,9,3},
// };
// int[,] matrix2 = new int[,]
// {
//     {9,8},
//     {1,2},
//     {3,4},
//     {6,7},
// };
//int[,] matrRes = new int[3, 2];
//PrintMultiArray(matrRes);


//Ручное вычисление для проверки
//PrintMultiArray(matrRes);
// matrRes[0, 0] = matrix1[0, 0] * matrix2[0, 0]
//                 + matrix1[0, 1] * matrix2[1, 0]
//                 + matrix1[0, 2] * matrix2[2, 0]
//                 + matrix1[0, 3] * matrix2[3, 0];
// System.Console.Write(matrRes[0, 0] + " ");
// matrRes[0, 1] = matrix1[1, 0] * matrix2[0, 1]
//                 + matrix1[1, 1] * matrix2[1, 1]
//                 + matrix1[1, 2] * matrix2[2, 1]
//                 + matrix1[1, 3] * matrix2[3, 1];
// System.Console.WriteLine(matrRes[0, 1]);

// Цикл вычисления произведения без метода
// int[,] matrRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
// for (int x = 0; x < matrix1.GetLength(0); x++)
//     {
//         for (int y = 0; y < matrix2.GetLength(1); y++)
//         {
//             matrRes[x, y] = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 matrRes[x, y] = matrRes[x, y] + matrix1[x, k] * matrix2[k, y];

//             }
//         }
//     }


int[,] matrix1 = new int[3, 4];
int[,] matrix2 = new int[4, 2];
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    FillMultiArray(matrix1);
    FillMultiArray(matrix2);
    PrintMultiArray(matrix1);
    System.Console.WriteLine();
    PrintMultiArray(matrix2);
    System.Console.WriteLine();
    int[,] matrRes = ProductMultiArray(matrix1, matrix2);
    ProductMultiArray(matrix1, matrix2);
    PrintMultiArray(matrRes);
}
else
{
    System.Console.WriteLine(
        $"Матрицы не могут быть перемножены,т.к. они не совместимы - "
        + "число столбцов матрицы1 не равно числу строк матрицы2");
}




