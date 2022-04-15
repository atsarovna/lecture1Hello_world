int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} // первый элемент имеет индекс 0, следующий через 1, 2, 3, и тд
//              0  1   2   3   4   5   6    7   8
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
//array[0]=12; //нулевому(0) значению массива присвоить число 12. сейчас 11. каким образом можно обратиться к массиву и записать в него знаяение
//Console.WriteLine(array[4]); //показываю каким образом можно обратиться к массиву и получить значение соответствующего эллемента по указанному индексу

int result = Max(                    //функция
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])); 

Console.WriteLine(result);
//поиск максимума из 9
