//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArrayRandomNums(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10, 99);
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

int[,] array = new int[8, 4];

FillArrayRandomNums(array);
PrintArray(array);
Console.WriteLine();
int indexMinRow = 0;
int MinSum = int.MaxValue;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < MinSum)
    {
        MinSum = sum;
        indexMinRow = i;
    }
    Console.WriteLine(sum);


}
Console.WriteLine();
Console.WriteLine($"Строка с индексом {indexMinRow} имеет наименьшую сумму элементов");


