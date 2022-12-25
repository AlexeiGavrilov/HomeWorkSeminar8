// Задайте две квадратные матрицы одинакового размера. Напишите программу, которая будет находить произведение двух матриц.
void FillArrayRandomNums(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            arr3[i, j] = sum;
        }
    }
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] ResultArray = new int[array1.GetLength(0), array1.GetLength(1)];

FillArrayRandomNums(array1);
FillArrayRandomNums(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

MultiplyArray(array1, array2, ResultArray);
PrintArray(ResultArray);















/*
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] ResultArray = new int[array1.GetLength(0), array1.GetLength(1)];


int result1 = (array1[0, 0] * array2[0, 0]) + (array1[0, 1] * array2[1, 0]);
int result2 = (array1[0, 0] * array2[0, 1]) + (array1[0, 1] * array2[1, 1]);
int result3 = (array1[1, 0] * array2[0, 0]) + (array1[1, 1] * array2[1, 0]);
int result4 = (array1[1, 0] * array2[0, 1]) + (array1[1, 1] * array2[1, 1]);

ResultArray[0, 0] = result1;
ResultArray[0, 1] = result2;
ResultArray[1, 0] = result3;
ResultArray[1, 1] = result4;
PrintArray(ResultArray);
*/

