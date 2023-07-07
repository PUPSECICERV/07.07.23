// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// написать программу, которая выводит наибольшее число из случайных чтсел от 10 до 99.

// Console.WriteLine("Генерируем двухзначное число");

// int i = new Random().Next(10, 99);

// Console.WriteLine(i);

// int answer = i % 10;
// Console.WriteLine(answer);

// i /= 10;

// Console.WriteLine(i);

// if (answer>i){
//     Console.WriteLine($"Наибольшее число: {answer}");
// }
// else Console.WriteLine($"Наибольшее число: {i}");

// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

// Console.WriteLine("Генерируем трехзначное число");

// int number = new Random().Next(100, 1000);

// Console.WriteLine(number);

// int number1 = number / 100;

// int number2 = number % 10;
// Console.Write($"Выводим первую и последнюю цифру числа {number1}{number2}");


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

// Console.Write("введите первое число:");
// int firstNumber = Int32.Parse(Console.ReadLine());
// Console.Write("введите второе число: ");
// int secondNumber = Int32.Parse(Console.ReadLine());
// int ostatok = firstNumber % secondNumber;
// if (ostatok == 0) {
//     Console.WriteLine ("Первое число кратно второму");
// } else {
//     Console.WriteLine ($"Первое число не кратно второму, остаток от деления {ostatok}");
// }

// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

// Console.Write("Input first number:");
// int firstNumber = Int32.Parse(Console.ReadLine());
// if ((firstNumber % 7 == 0) && (firstNumber % 23 == 0) ) {
//     Console.WriteLine ("Данное число кратно и 7, и 23");
// } else {
//     Console.WriteLine ($"Данное число не кратно 7 и 23");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// Console.WriteLine("Введите два числа: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// if ((number2 * number2 == number1) || (number1 * number1 == number2))
// {
//     Console.WriteLine("Да");
// }
// else { Console.WriteLine("Нет"); }
