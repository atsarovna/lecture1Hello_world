void FillArray(int [] collection) //аргумент collection(любое название)
{
    int length = collection.Length; //длина массива <имя array>.Length
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random() .Next(1, 10); //диапозон целых чисел 1-10 - .Next(1ю 10) 
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length; //кол-во элементов
    int position = 0; //позиция элемента
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
// void - ничего не возвращает.не нужно использовать оператор return
int [] array = new int [10]; //new int[] - создай новый массив,который содержит 10 элементов

FillArray(array); //заполнил массив
PrintArray(array); //распечатал массив