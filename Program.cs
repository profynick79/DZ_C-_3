// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координату точки А по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки В по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки В по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// var result = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Результат: {result, 2}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // for(начало; условие; увеличение переменной - счетчика)
// for(int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void CheckingNumber(string number)
{
if (number[0]==number[4] || number[1]==number[3])
    {
    Console.WriteLine($"Ваше число: {number} является палиндромом.");
    }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");

