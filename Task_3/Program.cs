// Задание 3
// Проверка на четность
// Внутри класса Answer напишите метод CheckIfEven,
// который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
// https://autotest.gb.ru/problems/4

using System;

public class Answer {
    static string CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        string result = "Введенные числа равны " + firstNumber;

        if (firstNumber < secondNumber)
        {
          result = "Первое число " + firstNumber + " меньше, чем второе число " + secondNumber;
        }

        if (firstNumber > secondNumber)
        {
          result = "Первое число " + firstNumber + " больше, чем второе число " + secondNumber;
        } 
           
      return result;
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = -3;
            secondNumber = -9;
        }

        // Не удаляйте строки ниже
        Console.Write(CompareNumbers(firstNumber, secondNumber));
    }
}