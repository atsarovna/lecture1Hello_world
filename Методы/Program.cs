// 1 вид методов. Которые не принимают никакие данные и не возвращают
void Method1()
{
    Console.WriteLine("Автор ..."); //например, если я хочу ооставить свою подпись в конце каждой программы
}
Method1(); //вызываем такой метод так

//2 вид метода. 
void Method2(String msg) //строка сообщение
{
    Console.WriteLine(msg);
}
//Method2("текст сообщения"); //вызываем метод. показываем какое сообщение

//если метод принимает > 1 агумента
void Method21(String msg, int count) // count - значение переменной,которая показывает какое кол-во сообщений передается
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "текст сообщения",count: 4); // 4 - сколько раз нужно вывести в консоль. если несколько значений,то можно для каждой назначит содержание.
Method21(count: 4, msg: "текст сообщения"); // можно и наоборот

//3 вид метода. Аргументы не принимает,но возвращает

int Method3()
{
    return DateTime.Now.Year; //текущая дата и год
}

int year = Method3(); //идентификатор переменной год кладем нужное значение через оператор присваивания
Console.WriteLine(year); //выводим значение

//вид4. Что-то принимают и возвращают
string Method4(int count, string text) //строку text будет выводит count раз
{
    int i = 0;
    string result = String.Empty; //result - это пустая строка. можно указывать как ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
