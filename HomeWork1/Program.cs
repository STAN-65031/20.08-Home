// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreatesArray(int number)
{
    int[] NewArray = new int[number];
    Random random = new Random();
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = random.Next(100,1000);
    }
    return NewArray;
}

 int FindEvenNumbers(int[] arr)
 {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
 }
 int[] arryy = CreatesArray(size);
 int result = FindEvenNumbers(arryy);
 Console.WriteLine(result);
