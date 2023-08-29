// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int NumUser (string user)
// {
//     int num = int.Parse(user);
//     return num;
// }

// int CountNumUser ()
// {
//     int count = 0;
//     string userEnter = string.Empty;
//     System.Console.WriteLine("Вводи числа. Программа посчитает количество чисел, \n" +
//     "которые больше нуля. Захочешь остановиться, введи q");
//     while (userEnter != "q")
//     {
//         System.Console.WriteLine($"Введите число");
//         userEnter = Console.ReadLine();
//         if (userEnter == "q") 
//         {
//             break;
//         }
//         else 
//         {
//         int num = NumUser(userEnter);
//         if (num > 0) count++;
//         }
//     }
    
//     return count;
// }

// System.Console.WriteLine($"Количество элементов больше нуля - {CountNumUser()}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string msg)
{
    Console.Write($"{msg}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

// double FindX (double k1, double b1, double k2, double b2)
// {
//     double x = (b1 - b2) / (-1 * (k1 - k2));
//     return x;
// }

// double FindY (double x, double k2, double b2)
// {
//     double y = k2 * x + b2;
//     return y;
// }

// double k1 = Prompt("Введите к1");
// double b1 = Prompt("Введите b1");
// double k2 = Prompt("Введите к2");
// double b2 = Prompt("Введите b2");

// double x = Math.Round(FindX(k1, b1, k2, b2), 1);
// double y = Math.Round(FindY(x, k2, b2), 1);

// Console.WriteLine($"X = {x}, Y = {y}");

// ideal resolve 

const int COEFFICIENT = 0;
const int CONSTANT = 1; 
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1; 
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines (lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    System.Console.Write($" Точка пересечения уравнений y = {lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} \n" +
    $"y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]} ");
    System.Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coord[Y_COORD] = lineData2[COEFFICIENT] * coord[X_COORD] + lineData2[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else 
        {
            System.Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}