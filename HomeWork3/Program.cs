// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());

double[] CreatesArray(int number)
{
    double[] NewArray = new double[number];
    Random random = new Random();
   
    for (int i = 0; i < NewArray.Length; i++)
    {
         double rr = Convert.ToDouble(random.Next(-100, 100)/10.0);
        NewArray[i] = rr;
    }
    return NewArray;
}

void PrintArray(double[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write($"{arr[i]} "); 
    } 
} 


double FindMaxNumber (double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMinNumber (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double FindDifferenceBetweenNumbers (double num1, double num2)
{
    double result= num1 - num2;
    return result;
}

double[] n = CreatesArray(size); 
PrintArray(n); 

double numberMax = FindMaxNumber(n);
Console.WriteLine();
Console.WriteLine("максимальное число : {0}", numberMax);
double numberMin = FindMinNumber(n);
Console.WriteLine();
Console.WriteLine("минимальное число : {0}", numberMin);
double result = FindDifferenceBetweenNumbers(numberMax, numberMin);
Console.WriteLine();
Console.WriteLine("результат {0}", result);