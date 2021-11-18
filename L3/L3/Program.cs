/*0
 ЛР-03
Работа со строками
Задание
Исходными данными в работе является строка, составленная по следующим правилам:
..1. длина строки составляет не более 200 символов;
2. строка состоит из нескольких предложений( >= 3 );
3. в конце каждого предложения есть точка;
..4. каждому слову, кроме первого, предшествует один пробел;
5. знаки препинания, если они есть, пишутся сразу после слова (без предшествующего пробела).
Программа должна печатать на экране исходную строку и строки, получившиеся в результате заданных преобразований.    
 
Вариант 06. Если длина строки L четная, то выделяется подстрока до первого пробела.
 
 */
using System;

namespace L3
{
    class Program
    {
       
        static void Main()
        {
            /* string str = "Два друга шли домой дорогой ночной, вдруг разбойники из леса Вышли целою толпой. Один парень зарыдал, на колени упал:" +
                           " Ох, не троньте вы меня, Все для вас исполню я!  ";


             Console.WriteLine(str); */
            Console.WriteLine("Введите строку: ");
            string str = Input_Valid_String();

            int length_str = str.Length % 2;

            if (length_str == 0)
            {
                Console.WriteLine("\nВ строке четное количество символов:" + str.Length + "\nИсходная строка:\n" + str);
                Console.WriteLine("\nПодстрока:");

                Console.WriteLine(str.Remove(str.IndexOf(" ")));
            }
            else {
                Console.WriteLine("\nВ строке нечетное количество символов:" + str.Length);
            }
 
        }

        private static string Input_Valid_String() {
            string str_boof = Console.ReadLine();
            while (str_boof.Length > 200 || str_boof.Contains("  ") || str_boof.StartsWith(' '))
            {
                int k = 0;
                if (str_boof.Length > 200)
                {
                    
                        Console.WriteLine("Строка превышает максималное количество символов!\nМаксимальное количество символов: 200");
                    
                    ++k;
                    
                }

                //4.каждому слову, кроме первого, предшествует один пробел;
                if (str_boof.Contains("  ") || str_boof.StartsWith(' '))
                {
                    
                        Console.WriteLine("Лишний пробел!");
                 
                    ++k;
                }

                if (k > 0) {
                    Console.WriteLine("ФУ!");
                    str_boof = Console.ReadLine();
                }
                /*
                //1.длина строки составляет не более 200 символов;
                if (str_boof.Length > 200) {
                    while (str_boof.Length > 200)
                    {
                        Console.WriteLine("Строка превышает максималное количество символов!\nМаксимальное количество символов: 200\nВведите строку снова:");
                        str_boof = Console.ReadLine();
                    }
                }

                //4.каждому слову, кроме первого, предшествует один пробел;
                if (str_boof.Contains("  ") || str_boof.StartsWith(' ')) {
                    while (str_boof.Contains("  ") || str_boof.StartsWith(' '))
                    {
                        Console.WriteLine("Лишний пробел!\nВведите строку снова:");
                        str_boof = Console.ReadLine();
                    }
                }*/

                //int count = (str_boof.Length - str_boof.Replace("  ", " ").Length);
                //Console.WriteLine("cont: " + count);

                string[] simbols = { " !", " .", " ?", " ,", " :", " ;" };

                //5.знаки препинания, если они есть, пишутся сразу после слова(без предшествующего пробела).
                /*bool flag = true;
                for (int i = 0; i < simbols.Length; i++)
                {
                    if (str_boof.Contains(simbols[i]))
                    {
                       Console.WriteLine("ФУ!");
                       flag = false;
                    }
                }
                if (!flag)
                {

                }
                */
            }
            return str_boof;
        }

    }
}
