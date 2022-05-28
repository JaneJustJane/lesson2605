// В двумерном массиве n×k заменить четные элементы на противоположные

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

void ChangeArray (int [,] matrix3)
{
    for (int i=0;i<matrix3.GetLength(0); i++)
    {
        for (int j=0; j<matrix3.GetLength(1); j++)
        {
            if (matrix3[i,j]%2==0)
            matrix3[i,j]= -matrix3[i,j];

        }
    }
}

Console.WriteLine("введите число n ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите число k ");
int k = int.Parse(Console.ReadLine() ?? "0");

int[,] mtrx = new int[n,k];

FillArray(mtrx);
PrintArray(mtrx);
Console.WriteLine();
ChangeArray(mtrx);
PrintArray(mtrx);