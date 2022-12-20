// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

FillArrayRandom(arr);
void FillArrayRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, 10);
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
    for (int a = 1; a < arr.Length; a += 2)
        count = count + arr[a];
    Console.WriteLine($"Сумма элементов массива в нечетных позициях равна: {count}.");
}
