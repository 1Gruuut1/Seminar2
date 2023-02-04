// Задача 1. Напишите программу, которая принимает на вход трёхзначное число
// и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}


Console.Write("Input a number:");
int num = Convert.ToInt32(Console.ReadLine());

int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/
/*
int num = new Random().Next(100, 1000);

int newNum = CutNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/
// Задача 1. Напишите программу, которая получает случайное число из
// отрезка [10, 99] и показвает наибольшую цифру числа. 
/*
int MaxNumber(int number)
{
    int dec = number / 10;
    int det = number % 10;
    int result = dec;

    if(det > result)
    {
       result = det;
    }
return result;
}

int num = new Random().Next(10, 100);
int max = MaxNumber(num);

Console.WriteLine($"Maximum number {num} and {max}");
*/
// Задача 2. Напишите программу, которая будет принимать на вход два числа
// и выводить являеться ли второе число кратным первому.

// Задание 3. Напишите программу, которая принимает на вход два числа
// и выводит, являеться ли одно кратное другому.

// Домашнее задание:
// Задача 10: Напишите программу,которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int NewFigure(int meaning)
{
    int result = meaning / 10 % 10;
    return result;
}

Console.Write("Input a number from 100 to 999: ");
int num = Convert.ToInt32(Console.ReadLine());

int figure = NewFigure(num);
Console.WriteLine(figure);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;    
}


Console.Write("Input a numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNum = ThirdDigit(num);
Console.WriteLine(newNum);
*/

// Задача 15: Напишите программу,которая принимает на вход цифру, обозначающую
// день недели, и проверяет, являеться ли этот день выходным.
/*
bool DayWeek(int number)
{
    bool result = true;
    if (number <= 5 || number > 7)
    {
        result = false;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = DayWeek(num);
Console.WriteLine(result);
*/