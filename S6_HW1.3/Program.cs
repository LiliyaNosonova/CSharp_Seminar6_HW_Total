// ДЗ ЗАДАЧА 1. Составить частотный словарь элементов двумерного массива:
//              частотный массив для текстовых данных.
// Решение.Вариант 1: разложение текстовой строки в массив и последующая его сортировка.


char[] ConvertArrayToString(string Text)
{
    char[] TextArray = new char[Text.Length];
    for (int i = 0; i < Text.Length; i++)
    {
        TextArray[i] = Text[i];
    }
    return TextArray;
}
void PrintTextArray(char[] Arr2)
{
    for (int position = 0; position < Arr2.Length; position++)
    {
        System.Console.Write(Arr2[position] + " ");
        System.Console.WriteLine();
    }
}

void SortCharSelection(char[] matrix)
{

    for (int i = 0; i < matrix.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i + 1; j < matrix.Length; j++)
        {
            if (matrix[j] < matrix[MinPos]) MinPos = j;
        }
        char temp = matrix[i];
        matrix[i] = matrix[MinPos];
        matrix[MinPos] = temp;
    }
}

void WordBookChar(char[] arr)
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
                System.Console.WriteLine($"Символ: {arr[k]}; встречается раз: {col}; частота: {percent}%");
                col = 1;
                percent = Math.Round((col * 100 / arr.Length),2);
            
            }
            
        }
        else
        {
            
            System.Console.WriteLine($"Символ: {arr[k]}; встречается раз: {col}; частота: {percent}%");
        }
    }
}


string RealText = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении "
                + "о существовании нетривиального статистического распределения отдельных символов и их последовательностей "
                + "как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться "
                + "в процессе шифрования и дешифрования.";// объявляем строку
char[] TextAr = ConvertArrayToString(RealText);//переводим в масcив символов

// PrintTextArray(TextAr);//вывод массива
System.Console.WriteLine();
SortCharSelection(TextAr);//сортируем массив
// PrintTextArray(TextAr);//выводим отсортированный массив
WordBookChar(TextAr);





