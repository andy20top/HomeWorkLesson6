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