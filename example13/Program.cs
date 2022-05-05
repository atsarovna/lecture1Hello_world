
string[,] table = new string[2, 5];
//по умолчанию для строк инциализация выполняется константой Strrowsng.Empty
//столбики считаются с 0, то есть table[0,0] table[0,1] table[0,2]
//строки с 1, те table[1.0] table [1,1] table[1,2]

/* table[1, 2] = "слово"; //- строка 2 столбик

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); //[1,10)
        }
    }
}

PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // счетчик строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // счетчик столбцов
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

