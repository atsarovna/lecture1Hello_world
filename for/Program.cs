// Цикл FOR. Цикл все сразу собирает в одном месте
/* for(int i = 0; i<10; i++)
{
    Console.WriteLine(i)
} */

string Method4(int count, string text) //строку text будет выводит count раз
{
    string result = String.Empty; //result - это пустая строка. можно указывать как ""
    for( int i = 0;i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

//цикл внутри цикла
/* for( int i = 0;i < 10; i++)
{
    for( int j = 0;j < 10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
} */
// как пример таблица умножения
for( int i = 2;i <= 10; i++)
{
    for( int j = 2;j <= 10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i*j}");
    }
    Console.WriteLine();
}
