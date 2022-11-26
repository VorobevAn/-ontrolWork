
// Сформировать из массива строк массив строк длиной до 3 символов
//Первоночальный массив можно ввести с клавиатуры или задать на старте.



string[] text = { "Olya", "has", "a", "pencil", "Olya", "has", "a", "pen", "She", "draws", "with", "a", "pencil", "She", "writes", "with", "a", "pen" };
Print(text);
string[] text2 = Sort(text);
Console.WriteLine();
Print(text2);

string[] Sort(string[] text)
{
    int j = 0;
    string[] text2 = new string[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            text2[j] = text[i];
            j++;
        }
    }
    return text2;
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}