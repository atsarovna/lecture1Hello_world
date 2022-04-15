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

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет, то указываем -1 или -2 и тд
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //прерываем на первой позиции(на первой цифре,Если неск-ко одинаковых)
        }
        index++; 
    }
    return position;
}

int [] array = new int [10]; 

FillArray(array); 
array[4] = 4; //искуственно ввела еще две 4, чтобы было понятно
array[6] = 4; //прерывается метод на первой 4 или нет

PrintArray(array); 
Console.WriteLine();

int pos = IndexOf(array, 4); //найти позицию/индекс числа 4. можно менять и подставлять любое число
Console.WriteLine(pos);

//нахождение позиции нужного элемента с использованием метода