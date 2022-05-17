using System;

namespace Task1 
{
    class main
    {
        static void Main(string[] args)
        {
            // Задание 1. Создание переменных и вывод
            string fullName = "Иванов Иван Иванович";
            int age = 20;
            string email = "somebody@gmail.com";
            double programmingPoints = 100;
            double mathPoints = 86.5;
            double phisicsPoints = 60.75;

            Console.WriteLine($"Имя - {fullName} \nВозраст - {age} \nEmail - {email} \n" +
                $"Баллы по программированию - {programmingPoints} \nБаллы по математике - {mathPoints} \nБаллы по физике - {phisicsPoints}\n");

            /* Немного не понял, что значит "Вывод последовательный, по нажатию клавиши."
               но, наверно, угадал */
            Console.ReadKey();


            // Задание 2. Реализация подсчёта количества баллов по всем предметам
            double totalPoints = programmingPoints + mathPoints + phisicsPoints;
            double avgPoints = totalPoints / 3;

            Console.WriteLine($"Общее колличество баллов = {totalPoints} \nСреднее колличество баллов = {avgPoints:.000}");
        }
    }
}
