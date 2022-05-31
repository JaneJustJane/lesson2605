//  В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет

void FillArray(int[,] matrix1)
{
    for (int i=0; i<matrix1.GetLength(0);i++)
    {
        for (int j=0; j<matrix1.GetLength(1);j++)
        {
            matrix1[i,j]=new Random().Next(1,10);
        }
    }
}

void PrintArray (int[,] matrix2)
{
    for (int i=0; i<matrix2.GetLength(0);i++)
    {
        for (int j=0; j<matrix2.GetLength(1);j++)
        {
            Console.Write($"{matrix2[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Search (int[,] matrix3, int search)
{
    int count = 0;
    for (int i=0; i<matrix3.GetLength(0);i++)
    {
        for (int j=0; j<matrix3.GetLength(1);j++)
        {
            if (matrix3[i,j]==search)
            Console.WriteLine($"число {search} находится на позиции [{i},{j}] ");
            count = 1;
        }
    }
    if (count == 0) Console.WriteLine($"числа {search} в данном массиве нет!");
}

Console.WriteLine("введите число a ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число b ");
int b = int.Parse(Console.ReadLine() ?? "0");

int[,] mtrx = new int[a,b];

Console.WriteLine("введите число n ");
int n = int.Parse(Console.ReadLine() ?? "0");

FillArray(mtrx);
PrintArray(mtrx);
Search(mtrx,n);

