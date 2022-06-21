// ДЗ ЗАДАЧА 1.1. Составить частотный словарь элементов двумерного массива
//                Входные данные - целочисленный массив.
// Решение: сортировка и последующее сравнение элементов массива.



// Метод задания целочисленного одномерного массива
void NewArray(int[] Arr1)
{
    for (int position = 0; position < Arr1.Length; position++)
    {
        Arr1[position] = new Random().Next(0, 10);
    }
}

// Метод вывода целочисленного одномерного массива
void PrintNewArray(int[] Arr2)
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
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
    double percent = Math.Round((col * 100 / arr.Length),2);
    for (int k = 0; k < arr.Length; k++)
    {
        if (k != arr.Length - 1)
        {
            if (arr[k] == arr[k + 1])
            {
                col++;
                percent = Math.Round((col * 100 / arr.Length),2);
            }
            else
            {
                System.Console.WriteLine($"Число: {arr[k]}; встречается раз: {col}; частота: {percent}%");
                col = 1;
                percent = Math.Round((col * 100 / arr.Length),2);
            
            }
            
        }
        else
        {
            
            System.Console.WriteLine($"Число: {arr[k]}; встречается раз: {col}; частота: {percent}%");
        }
    }
}

int[] RealArray = new int[13];
NewArray(RealArray);
System.Console.WriteLine("Исходный массив:");
PrintNewArray(RealArray);
System.Console.WriteLine();
SortSelection(RealArray);
System.Console.WriteLine();
System.Console.WriteLine("Массив после сортировки:");
PrintNewArray(RealArray);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Частотный словарь заданного целочисленного массива:");
WordBook(RealArray);





