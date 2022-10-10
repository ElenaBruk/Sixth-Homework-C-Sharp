// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double GetValue(string text)
{
    Console.Write($"Введите значение коэффициента {text}: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return (value);
}

double k1 = GetValue("k1");
double b1 = GetValue("b1");
double k2 = GetValue("k2");
double b2 = GetValue("b2");

void GetCrossPoint()
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * x + b1), 2);
    if (k1 == k2)
        Console.Write("Прямые параллельны друг другу и не имеют точек пересечения");
    else
        Console.Write($"Координаты точки пересечения прямых (x = {x}, y = {y})");
}

GetCrossPoint();