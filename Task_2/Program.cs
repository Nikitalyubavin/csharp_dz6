/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.Clear();
Console.WriteLine("Для начала определим коэффициенты K и B двух уравнений.");
double k1 = UserInput("Введите коэффициент K1: ", "Введено неверное значение!");
double b1 = UserInput("Введите коэффициент B1: ", "Введено неверное значение!");
double k2 = UserInput("Введите коэффициент K2: ", "Введено неверное значение!");
double b2 = UserInput("Введите коэффициент B2: ", "Введено неверное значение!");

double x = FindX(k1, b1, k2, b2);
double y = FindY(x);
Console.WriteLine($"K1 = {k1}, B1 = {b1}, K2 = {k2}, B2 = {b2} -> ({x}; {y})");



double FindX(double K1, double B1, double K2, double B2)
{
    double x = (B2 - B1) / (K1 - K2);
    return x;
}

double FindY(double x)
{
    double y = k1 * x + b1;
    return y;
}

double UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine()??"", out double number)) return number;
        Console.WriteLine(errorMessage);
    }    
}