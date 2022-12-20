// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
double[] arr = new double[size];

FillArrayRandom(arr);
void FillArrayRandom(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
        }
    Console.Write("Массив создан: ");
}

PrintArray(arr);
void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

CalculationArray(arr);
void CalculationArray(double[] arr)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int a = 0; a < arr.Length; a++)
        {
            if (arr[a] > max)
                {
                    max = arr[a];
                }
            if (arr[a] < min)
                {
                    min = arr[a];
                }
        }
    Console.WriteLine($"Максимальное число в массиве: {max}, минимальное число в массиве: {min}, разница между максимальным и минимальным элементом массива: {max - min}");
}
