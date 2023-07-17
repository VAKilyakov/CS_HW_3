/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

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