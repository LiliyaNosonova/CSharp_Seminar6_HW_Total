// ДЗ ЗАДАЧА 1. Составить частотный словарь элементов двумерного массива:
//              частотный массив для текстовых данных.
// Решение.Вариант 2: построение словаря с заменой отработанных символов на пробелы.

string RealText = "привет прикол ";
// System.Console.WriteLine(RealText);
// string Text = RealText.Replace('и', 'e');
// System.Console.WriteLine(Text);

// посчитаем и отобразим все пробелы
double count = 0;
for (int i = 0; i < RealText.Length; i++)
{
    if (RealText[i] == ' ') count++;
}
System.Console.WriteLine($"пробелов в тексте - {count}");

// посчитаем и отобразим остальные символы, меняя их при поиске на пробелы

char temp = ' ';
double percent = 0;
string Text = RealText;// сохраняем исходный текст
for (int i = 0; i < RealText.Length; i++)
{
    count = 1;
    temp = Text[i];

    if (temp != ' ')
    {
        for (int j = 0; j < RealText.Length; j++)
        {
            if ((Text[j] == temp) & (i != j))
            {
                count++;
            } 
        }
        percent = Math.Round((count * 100 / RealText.Length), 2);
        System.Console.WriteLine($"символов '{temp}' в тексте - {count}, частота {percent}%");
        Text = Text.Replace(temp, ' ');
    }
}
