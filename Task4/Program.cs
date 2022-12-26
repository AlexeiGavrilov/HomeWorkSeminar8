///Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. Напишите программу, которая будет построчно выводить массив.
bool IsNumberInArray(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                return true;
            }

        }
    }

    return false;
}

void FillArrayRandomNums(int[,] arr)
{
    Random rand = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            while (arr[i, j] == 0)
            {
                int number = rand.Next(10, 99);

                if (IsNumberInArray(arr, number) == false)
                {
                    arr[i, j] = number;
                }
            }


        }
    }
}

void PrintArray2DInLine(int[,] arr)
{
    foreach (int nums in arr)
    {
        Console.Write(nums + " ");
    }

}

int[,] array2D = new int[7, 7];
FillArrayRandomNums(array2D);
PrintArray2DInLine(array2D);
