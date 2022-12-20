// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

FillArrayRandom(arr);
void FillArrayRandom(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(100, 1000);
        }
    Console.Write("Массив создан: ");
}

PrintArray(arr);
void PrintArray(int[] arr)
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
void CalculationArray(int[] arr)
{
    int count = 0;
    for (int a = 0; a < arr.Length; a++)
        if (arr[a] % 2 == 0)
            count++;
    Console.WriteLine($"В массиве четных чисел {count}.");
}
