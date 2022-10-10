// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputNumber()
{
    Console.Write("Ведите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void EnterArray(int[] array, int i)
{
    if (i < array.Length)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
        EnterArray(array, i);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

void CountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше 0.");
}

int[] array = new int[InputNumber()];
EnterArray(array, 0);
PrintArray(array);
CountOfNumbers(array);