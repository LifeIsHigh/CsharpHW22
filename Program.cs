// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Enter value = number of Rows : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value = number of Columns : ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] Array = new int[x, y];

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i, j] = new Random().Next(-9, 10);
        Console.Write($"{Array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
void NewArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            int left = 0;
            int right = Array.GetLength(1) - 1;
            while (left <= right)
            {
                for (int k = right; k > left; --k)
                {
                    if (Array[i, k] > Array[i, k - 1])
                    {
                        int max = Array[i, k - 1];
                        Array[i, k - 1] = Array[i, k];
                        Array[i, k] = max;
                    }
                }
                ++left;
                for (int k = left; k < right; ++k)
                {
                    if (Array[i, k + 1] > Array[i, k])
                    {
                        int max = Array[i, k + 1];
                        Array[i, k + 1] = Array[i, k];
                        Array[i, k] = max;
                    }
                }
                --right;
            }
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}
NewArray(Array);