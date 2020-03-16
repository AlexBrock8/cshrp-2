using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_02
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)

        {
            #region Задание
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.
            #endregion


            string name; // Имя
            byte age; // Возраст
            float growth; // Рост 

            uint history; // Оценка по истории
            uint math; // Оценка по математике
            uint russian; // Оценка по русскому

            name = "Александра Пестова";
            age = 23;
            growth = 165.00F;
            history = 4;
            math = 3;
            russian = 5;

            FirstPrint(name, age, growth, history, math, russian); //печать
            SecondPrint(name, age, growth, history, math, russian); //печать
            ThirdPrint(name, age, growth, history, math, russian); //печать


            Console.ReadKey();
        }


        /// <summary>
        /// Подсчёт среднего балла
        /// </summary>

        // считаем средний балл, складываем оценки всех предметов и общую сумму делим на количество предметов
        static double AverageScore(uint history, uint math, uint russian)
        {
            return (double)(history + math + russian) / 3;
        }


        /// <summary> 
        /// Обычный ввод 
        /// </summary>
        static void FirstPrint(string name, byte age, float growth, uint history, uint math, uint russian)
        {
            // средний балл, переводим его


            double averageScore = AverageScore(history, math, russian);
            string averageScoreFormatted = averageScore.ToString("#.##");


            // формат вывода
            string first1 = ("Обычный вывод");

            // Вывод по центру первой строки
            Console.SetCursorPosition((Console.WindowWidth - first1.Length) / 2, Console.CursorTop);
            Console.WriteLine(first1);


            // формат вывода
            string first2 = (name + " " + age + " " + growth.ToString("#.##") + " " + history +
                " " + math + " " + russian + " " + averageScoreFormatted);

            // Вывод по центру второй строки
            Console.SetCursorPosition((Console.WindowWidth - first2.Length) / 2, Console.CursorTop);
            Console.WriteLine(first2);

        }


        /// <summary> 
        /// Форматированный
        /// </summary>
        static void SecondPrint(string name, byte age, float growth, uint history, uint math, uint russian)
        {
            // средний балл, переводим его

            double averageScore = AverageScore(history, math, russian);
            string averageScoreFormatted = averageScore.ToString("#.##");

            //формат вывода
            string second = "Имя: {0} \nВозраст: {1} \nРост: {2} \nБаллы по истории: {3} \n" +
            "Баллы по математике: {4} \nБаллы по русскому языку: {5} \nСредний балл: {6} \n";

            //вывод в консоль
            Console.WriteLine("Форматированный вывод");
            Console.WriteLine(second, name, age, growth.ToString("#.##"), history, math, russian, averageScore);
            i += 5;


        }

        /// <summary> 
        /// Интерполяция строк
        /// </summary>

        static void ThirdPrint(string name, byte age, float growth, uint history, uint math, uint russian)
        {
            // средний балл, переводим его

            double averageScore = AverageScore(history, math, russian);
            string averageScoreFormatted = averageScore.ToString("#.##");

            // вывод в консоль
            Console.WriteLine("Интерполяция строк");
            Console.WriteLine($"Имя: {name} \nВозраст: {age} \nРост: {growth.ToString("#.##")} \nБаллы по истории: {history} \n" + $"Баллы по математике: {math} \nБаллы по русскому языку: {russian} \nСредний балл: {averageScore} \n");
            Console.WriteLine();
            i += 5;

        }


    }
}