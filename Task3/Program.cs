// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число");

for(int i = 1; i < num; i++)
{
    double result = Math.Pow(i,3);
    System.Console.Write($"({result}), ");

}