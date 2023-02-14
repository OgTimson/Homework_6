/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или не корректное число. Повторите ввод:");
        }
    }
    return result;
}

int[] InitArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = GetNumber($"Введите {i + 1} элемент:");
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int CountPositiveNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int size = GetNumber("Введите количество элементов для массива:");
int[] arr = InitArray(size);
Console.WriteLine("Ваш массив готов:");
PrintArray(arr);
int count = CountPositiveNum(arr);
Console.WriteLine($"В вашем массиве количество чисел больше 0 = {count}");