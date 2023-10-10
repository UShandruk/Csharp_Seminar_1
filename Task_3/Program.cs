// Задание 3
// Проверка на четность
// Внутри класса Answer напишите метод CheckIfEven,
// который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
// number = 4 -> Число 4 чётное
// number = 3 -> Число 3 нечётное
// number = 7 -> Число 7 нечётное
// https://autotest.gb.ru/problems/4

using System;

class Answer {
    static string CheckIfEven(int number)
    {
      // Введите свое решение ниже
      string result = "Число `" + number;
      if(number%2 == 0)
      {
        result = result + "` чётное";
      }
      else result = result + "` нечётное";
      
      return result;
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
        Console.Write(CheckIfEven(number));
    }
}