/*
Вычислить суммы элементов матрицы, лежащих выше, ниже и на главной 
диагонали. 
*/

int n = 4;


//создаем матрицу
int[,] matrix = new int[n, n];

Random random = new Random();

//заполняем случайными значениями
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = random.Next(20);
    }
}

Console.WriteLine("Массив: ");

//вывод массива
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int sumAboveDiagonal = 0;
int sumOnDiagonal = 0;
int sumBelowDiagonal = 0;

//проходим по элементам матрицы
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i > j) //выше главной диагонали
        {
            sumAboveDiagonal += matrix[i, j];
        }
        else if (i == j) //на главной диагонали
        {
            sumOnDiagonal += matrix[i, j];
        }
        else if (i < j) //ниже главной диагонали
        {
            sumBelowDiagonal += matrix[i, j];
        }
    }
}
//выводим результаты
Console.WriteLine("\nСумма элементов выше главной диагонали: " + sumAboveDiagonal);
Console.WriteLine("Сумма элементов на главной диагонали: " + sumOnDiagonal);
Console.WriteLine("Сумма элементов ниже главной диагонали: " + sumBelowDiagonal);
