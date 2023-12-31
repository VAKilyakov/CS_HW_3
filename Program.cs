﻿/* Задача1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* Решение 1
bool EqualsNumber(int Number1, int Number2)
{

    if (Number1 == Number2)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int CutNumber(int Number, int Divider)
{
    int DelPref = Number % Divider;
    int DelPost = DelPref / (Divider/10);

    int Result = DelPost;

    return Result;
}

Console.Write("Enter a five-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number >=99999)
{
    Console.Write("You number is't five-digit");
    return;
}


if (EqualsNumber(CutNumber(number,10),CutNumber(number,100000)))
{
    
    if (EqualsNumber(CutNumber(number,100),CutNumber(number,10000)))
    {
        Console.Write("Yes, number is palindrom");
    }
    else
    {
        Console.Write("No, number is't palindrom"); 
    }

}
else
{

    Console.Write("No, number is't palindrom");

}
*/

/* Тесты 1
PS D:\Home_Works\CS_HW_3> dotnet run
Enter a five-digit number 14212
No, number is't palindrom
PS D:\Home_Works\CS_HW_3> dotnet run
Enter a five-digit number 12821
Yes, number is palindrom
PS D:\Home_Works\CS_HW_3> dotnet run
Enter a five-digit number 23432
Yes, number is palindrom
*/

/*Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/* Решение 2
int InputN(string message)
{
    Console.Write(message + " ");
    return Convert.ToInt32(Console.ReadLine());

}

double Distanse(int CoordinateA, int CoordinateB)
{
    return CoordinateB - CoordinateA;
}

int x1 = InputN ("Введите координату X точки A");
int y1 = InputN ("Введите координату Y точки A");
int z1 = InputN ("Введите координату Z точки A");
int x2 = InputN ("Введите координату X точки B");
int y2 = InputN ("Введите координату Y точки B");
int z2 = InputN ("Введите координату Z точки B");

double deltax = Distanse(x1,x2);
double deltay = Distanse(y1,y2);
double deltaz = Distanse(z1,z2);

double result = Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);

Console.Write("Растояние между точками A и B равно " + Math.Round(result,2));
*/

/* Тест 2
PS D:\Home_Works\CS_HW_3> dotnet run
Введите координату X точки A 3
Введите координату Y точки A 6
Введите координату Z точки A 8
Введите координату X точки B 2
Введите координату Y точки B 1
Введите координату Z точки B -7
Растояние между точками A и B равно 15,84
PS D:\Home_Works\CS_HW_3> dotnet run
Введите координату X точки A 7
Введите координату Y точки A -5
Введите координату Z точки A 0
Введите координату X точки B 1
Введите координату Y точки B -1
Введите координату Z точки B 9
Растояние между точками A и B равно 11,53
*/

/* Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
4
1 - 1
2 - 8
3 - 27
4 - 64
*/

/* Решение 3
double Cube (double Number)
{
    return Math.Pow(Number,3);
}

Console.Write("Input number: ");
double Number = Convert.ToDouble(Console.ReadLine());

int Counter = 1;

while (Counter < Number + 1)
{
    Console.WriteLine(Counter + " - " + Cube(Counter));
    Counter++;
}
*/

/* Тест 3
PS D:\Home_Works\CS_HW_3> dotnet run
Input number: 4
1 - 1
2 - 8
3 - 27
4 - 64
*/