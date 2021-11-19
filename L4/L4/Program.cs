/*Вариант 6. Составить регулярное выражение, 
 определяющее, является ли данная строчка валидным URL адресом 
(http://www.zcontest.ru, http://zcontest.ru/dir%201/dir_2/program.ext?var1=x&var2=my%20valuezcon.com/index.html#bookmark ).*/

using System;
using System.Text.RegularExpressions;

namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(https?):\/\/(([0-9a-zа-я-]*[.\/][a-zа-я]*))*(\/(.)*)?";
            string user_string;
            Console.WriteLine("Ведите URL для проверки");
            user_string = Console.ReadLine();
            if (!Regex.IsMatch(user_string, pattern))
            {

                while (!Regex.IsMatch(user_string, pattern)){
                    Console.WriteLine("URL не является валидним.\nВведите снова:");
                    user_string = Console.ReadLine();
                }
            }
            else {
                Console.WriteLine("URL является валидним.");
            }
        }
    }
}
