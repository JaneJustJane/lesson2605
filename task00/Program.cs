// Показать двумерный массив размером m×n заполненный целыми числами

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

Console.WriteLine("введите число m ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число n ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] mtrx = new int[m,n];

FillArray(mtrx);
PrintArray(mtrx);

