// int number = 123456;
// Console.WriteLine(number / 100 % 10);

//Поиск цифры по индексу через строку (строка всегда есть массив)
//string testNumber = Console.ReadLine();
//Console.WriteLine(testNumber[0]);
//Console.WriteLine(testNumber[1]);
//Console.WriteLine(testNumber[2]);


// var test = 10;
// var result = 100 * 0.5 / 2;
// var test1 = "Hello World";
// Console.WriteLine();

//ЗАДАЧА 1
// Вводится строчка. Необходимо проверить, являются ли 
// все введенные символы числами
// "1234" - подходит, в строчке число 1234, подходит
// "1234Привет" - не подходит



// var stringNumber = "1234Hello";
// int number; // если строчка состоит из чисел, то сюда попадает наше число
// bool isNumber = int.TryParse(stringNumber, out number); // True - строчка состоит из чисел, False - есть символы, буквы и т.п.
// if (isNumber) // isNumber == true
// {
//     Console.WriteLine("Перевод произошел успешно,в стрчоке находились ТОЛЬКО цифры");
//     Console.WriteLine(number);
// }
// else
// {
// Console.WriteLine("Перевод провалился: в строчке есть не только цифры");
//     Console.WriteLine(number);
// }

//ЗАДАЧА 2
//Напишите программу, которая принимает на вход 
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой 
//находится эта точка.

// Console.Write("Введите координату по оси Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// // A(x; y)
// if (x>0 && y >0)
// {
//     Console.WriteLine("Четверть I");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Четверть: II");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть: III");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть: IV");
// }
// else
// {
//     Console.WriteLine("Попаданиние на ось");
// }

// ЗАДАЧА 3
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



//корень((х1-х2)^2 + (у1-у2)^2)
//точка А
// Console.Write("Введите координату точки А по оси Х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// // точка В
// Console.Write("Введите координату точки В по оси Х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки В по оси Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// // AB = корень (х1-х2)^2 + (у1-у2)^2)
// var result = Math.Sqrt(Math.Pow(x2-x1, 2)+ Math.Pow(y2 -y1, 2));
// Console.WriteLine($"Результат:{result,f2}");

//Console.WriteLine(Math.Round(result, 3));


//Задача 22: Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i<=N)
// {
//     Console.Write(Math.Pow(i,2)+"\t");
//     //Литерал
//     //"\t" = Tab (4 пробела между элементами)
//     i++;
// }


// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i=1; i<=N; i++ )
// {
//     Console.Write(Math.Pow(i,2)+"\t");
//     }

// Четные числа от 0 до N включительно
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i=0; i<=N; i+=2)
// {
//     Console.Write(i +"\t");
//     }



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

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// for(начало; условие; увеличение переменной - счетчика)
for(int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}