// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int ax = ReadInt("Введите значения Х1:");
int bx = ReadInt("Введите значения Х2:");
int ay = ReadInt("Введите значения Y1:");
int by = ReadInt("Введите значение Y2:");
int az = ReadInt("Введите значение Z1:");
int bz = ReadInt("Введите значение Z2:"); 

// sqrt(pow(x2-x1),2 + (y2-y1),2 + (z2-z1),2)

double result = Math.Sqrt(Math.Pow((bx-ax), 2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz),2));

System.Console.WriteLine($"Результат: {result:f2}");