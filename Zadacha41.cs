/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Write("Введите рассматриваемый диапазон чисел: ");
int M = int.Parse(Console.ReadLine()!);

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i < M; i++)
    {
        Console.Write("Введите число:");
        res[i] = int.Parse(Console.ReadLine()!);;
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
}
int[] array = GetArray(M);
Console.Write("Полученный массив: ");
PrintArray(array);

int PosValue(int [] array)
{
    int i = 0;
    int value = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            value = value + 1;
            i++;
        }
        else
        {
            i++;
        }
    }
    return value;
}
Console.WriteLine($"Количество положительных чисел в массиве: {PosValue(array)}");