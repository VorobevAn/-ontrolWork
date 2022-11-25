
// Сформировать из массива строк массив строк длиной до 3 символов
//Первоночальный массив можно ввести с клавиатуры или задать на старте.


//Console.WriteLine("Введите текст: ");
//string t = Console.ReadLine()!;
string[] text = {"Olya","has","a","pencil","Olya","has","a","pen","She","draws","with","a","pencil","She","writes","with","a","pen"};

for (int i = 0; i < text.Length; i++)
{
    Console.Write($"{text[i]} ");
}

