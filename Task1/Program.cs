// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int ReadInt(string message)
{
    
    System.Console.Write($" {message} >");

    return Convert.ToInt32(Console.ReadLine());

}

int number = ReadInt("Введите число: ");
int first = number / 10000;
int second = number / 1000 % 10;
int third = number % 100 / 10;
int fourth = number % 10 ;

if(first == fourth && second == third)
    {
        System.Console.WriteLine("Да, является");
    }
    else{
        System.Console.WriteLine("No");
    }
