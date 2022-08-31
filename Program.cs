//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("Enter number: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"Ваше число: {number} - палиндром.");
//     }
//     else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5)
// {
//     CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Enter x1...");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z1...");
// int z1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// int y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z2...");
// int z2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((y2 - y1), 2));

// Console.WriteLine("длинна отрезка" + result);

// Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {result}");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//кубов чисел от 1 до N.

// Console.WriteLine("Enter number...");
// int cube = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Таблица кубов");

// for (int i = 1; i <= cube; i++)
// {
//     Console.WriteLine(Math.Pow(i, 3));
// }