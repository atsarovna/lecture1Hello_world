//Алгоритм сортировки методом выбора или алгоритм сортировки методом min и max
// 1. Найти позицию минимального элемента
//2.Произвести обмен этого значения со значением первой неотсротированной позиции
//3. Повторять пока есть не отсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// подзадача,которая выводит массив на экран
void PrintArray(int[] array) 
{
    int count = array.Length; // получение кол-ва элементов в массиве

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод,который будет упорядочивать массив
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) //тк j + 1, то array.Length - 1
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) // array.Length последний символ в массике, считать начинает от индекс + 1
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temporary = array[i]; //назначаем временную переменную, кладем туда текущее значение
        array[i] = array[minPosition]; //в текущее значение кладем минимальный символ
        array[minPosition] = temporary; //в позицию минимального символа кладем текущее значение 
    }
}

PrintArray(arr);
SelectionSort(arr); //1 первый метод выводим

PrintArray(arr); //2 метод выводим