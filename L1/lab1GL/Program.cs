/*
Неверовский Глеб, 5 вариант.
Задание 1. Выполните указанные действия.

Запросить через консоль фамилию и имя студента, а затем поздороваться с ним.
Изменить цвет фона и символов консоли.
Установить название окна консоли в соответствии с именем студента.
Установить размер окна консоли 50×50.
Выдать звуковой сигнал.
Отобразить состояние CapsLock и NumLock.
Скрыть курсор.

Задание 2. В соответствии с вариантом задания организуйте ввод требуемых исходных данных,
вывод результатов расчётов с использованием консоли. Для расчётов принять π=3,1415.

Прямая с известными параметрами a и b проходит через две точки O1(x1;y1) и O2(x2;y2), 
ординаты которых y1 и y2 известны. Определить xk если известно, что расстояния x1xk и x2xk одинаковы. Уравнение прямой y=ax+b.

*/



using System;


namespace LabFirst
{
    // Main Programm
    public class Programm
    {
        public static void Main()
        {

            new FirstEx();
            Console.WriteLine("Нажмите на любую кнопку для продолжения...");
            Console.ReadKey();
            new SecondEx();
        }
    }

    // First exercise
    public class FirstEx
    {
        private string name;
        private string surname;
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor)); //array of colors
        Random rndc = new Random();

        public static bool IsOnlyChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 'А' || str[i] > 'я')
                {
                    return false;
                }
            }

            return true;
        }

        public void SetUserAttributs()
        {
            Console.WriteLine("Введите фамилию студента: ");
            surname = Console.ReadLine();
            while (!IsOnlyChar(surname))
            {
                Console.WriteLine("[Ошибка ввода] в Фамилии должны быть только русские буквы, повторите ввод: ");
                surname = Console.ReadLine();
            }
            Console.WriteLine("Введите имя студента: ");
            name = Console.ReadLine();
            while (!IsOnlyChar(name))
            {
                Console.WriteLine("[Ошибка ввода] в Имени должны быть только русские буквы, повторите ввод: ");
                name = Console.ReadLine();
            }
        }

        public FirstEx()
        {
            Console.WriteLine("Задание №1");
            Console.SetWindowSize(50, 50);
          
            Console.BackgroundColor = colors[rndc.Next(0, 16)];
            Console.ForegroundColor = colors[rndc.Next(0, 16)];
            Console.Clear();
            SetUserAttributs();
            Console.WriteLine($"Привет, {name} {surname}");
            Console.Title = name;
            Console.WriteLine("После нажатия на клавишу будет звук: ");
            Console.ReadKey();
            Console.Beep();
            Console.WriteLine("Caps Lock: " + Console.CapsLock);
            Console.WriteLine("Num Lock: " + Console.NumberLock);
            Console.CursorVisible = false;

        }
    }

    //Second exercise
    public class SecondEx
    {
        private double a = 0, b = 0, y1 = 0, y2 = 0, xk = 0;

        public void SetUserAttributs()
        {
            Console.WriteLine("Введите аргумент a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число a");
            }
            Console.WriteLine("Введите аргумент b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите число b");
            }
            Console.WriteLine("Введите аргумент y1: ");
            while (!double.TryParse(Console.ReadLine(), out y1))
            {
                Console.WriteLine("Ошибка ввода! Введите число y1");
            }
            Console.WriteLine("Введите аргумент y2: ");
            while (!double.TryParse(Console.ReadLine(), out y2) || y2 == y1)
            {
                Console.WriteLine("Ошибка ввода! Введите число y2");
            }

        }

        public SecondEx()
        {
            Console.WriteLine("Задание №2");
            SetUserAttributs();
            xk = (y1 + y2 - 2 * b) / (2*a);
            Console.WriteLine($"Ответ: {xk} ");
        }

    }
}
