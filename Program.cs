// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int NumUser (string user)
{
    int num = int.Parse(user);
    return num;
}

int CountNumUser ()
{
    int count = 0;
    string userEnter = string.Empty;
    System.Console.WriteLine("Вводи числа. Программа посчитает количество чисел, \n" +
    "которые больше нуля. Захочешь остановиться, введи q");
    while (userEnter != "q")
    {
        System.Console.WriteLine($"Введите число");
        userEnter = Console.ReadLine();
        if (userEnter == "q") 
        {
            break;
        }
        else 
        {
        int num = NumUser(userEnter);
        if (num > 0) count++;
        }
    }
    
    return count;
}

System.Console.WriteLine($"Количество элементов больше нуля - {CountNumUser()}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string msg)
{
    Console.Write($"{msg}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double FindX (double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (-1 * (k1 - k2));
    return x;
}

double FindY (double x, double k2, double b2)
{
    double y = k2 * x + b2;
    return y;
}

double k1 = Prompt("Введите к1");
double b1 = Prompt("Введите b1");
double k2 = Prompt("Введите к2");
double b2 = Prompt("Введите b2");

double x = Math.Round(FindX(k1, b1, k2, b2), 1);
double y = Math.Round(FindY(x, k2, b2), 1);

Console.WriteLine($"X = {x}, Y = {y}");