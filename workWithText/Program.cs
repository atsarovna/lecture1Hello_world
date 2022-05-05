// === Работа с текстом
// Дан текст(в виде строки). В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими буквами "К", 
//а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty" - s - название строки, чтобы обратиться к какому-то символу мы можем отсчитывать слева направо буквы,начиная с 0. q - 0, w - 2, у - 3 и т.д.
//             0123
// s[3]  - это 2 элемент слова, то есть буква r

string Replace(string text, char oldValue, char newValue) // char - конкретный символ. oldValue - значение старого символа, newValue-значение нового символа,которые заменяем старый
{
    string result = string.Empty;
    int length = text.Length; //показывает кол-во символом в строке
    for (int i = 0; i < length; i++) //пробегаемся от 0 до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если символ равен старому значению, то заменяем на новый символ
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine(); // пустая строка, чтобы разделить 
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'с', 'С');
Console.WriteLine(newText);