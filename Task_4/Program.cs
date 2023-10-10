// Задание 4
// Внутри класса Answer напишите метод PrintEvenNumbers,
// которая на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
// https://autotest.gb.ru/problems/5

using System;

public class Answer {
    static string PrintEvenNumbers(int number)
    {
      
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        Console.Write(PrintEvenNumbers(number));
    }
}