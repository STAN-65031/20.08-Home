// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreatesArray(int number)
{
    int[] NewArray = new int[number];
    Random random = new Random();
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = random.Next(-1000,1000);
    }
    return NewArray;
}

void PrintArray(int[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write($"{arr[i]} "); 
    } 
} 

int FindSumNumbers (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum+arr[i];
    }
    return sum;
}

int[] n = CreatesArray(size); 
PrintArray(n); 
int result = FindSumNumbers(n);
Console.WriteLine();
Console.WriteLine(result);

