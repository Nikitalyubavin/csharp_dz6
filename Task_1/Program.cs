/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();
int count = 0;
int[] array = ArrayInput("Введите целое число: ", "Введено неправильное значение! Попробуйте снова!");
PrintArray(array);
Console.WriteLine($" -> {QuantityOfPositiveNumbers(array)}");



int QuantityOfPositiveNumbers(int[] inArray)
{
    int quantity = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0) quantity++;
    }
    return quantity;
}

int[] ArrayInput(string message, string errorMessage)
{
    int[] newArray = new int[10];
    int index = 0;
    while (index < 10)
    {
        Console.Write(message);
        if ((int.TryParse(Console.ReadLine()??"", out newArray[index])) == false)
        {
            Console.WriteLine(errorMessage);
            continue;
        }
        Console.WriteLine("Для завершения ввода чисел нажмите q, для продолжения - любую другую клавишу");
        index++;
        count++;
        if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
    }
    return newArray;    
}

void PrintArray(int[] arr)
{
    int index = 0;
    Console.Write("[");
    for (; index < count - 1; index++) Console.Write("{0}, ", arr[index]);
    if (index == count - 1) Console.Write($"{arr[index]}]");
}