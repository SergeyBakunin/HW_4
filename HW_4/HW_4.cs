using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
    internal class HW_4
    {
        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Exercise_1"); 
            Console.WriteLine("____________________________________");
            GetFullName("Бакунин", "Сергей", "Александрович");
            GetFullName("Попов", "Дмитрий", "Андреевич");
            GetFullName("Володина", "Ольга", "Романовна");
            GetFullName("Красова", "Анастасия", "Александровна");
            Console.WriteLine();
            // Второе задание
            Console.WriteLine("Exercise_2: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("Введите числа через пробел: ");
            string str = Console.ReadLine();
            var words = str.Split();
            int summary = default;
            for (int i = 0; i < words.Length; summary += int.Parse(words[i++])) ;
            Console.WriteLine("Сумма чисел равна: " + summary);
            Console.WriteLine();
            // Третье задание
            Console.WriteLine("Exercise_3: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("Введите номер месяца: ");
            Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            
            Console.ReadKey();
        }
        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine($"{firstName} {lastName} {patronymic}");
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "Зима";
                case season.Spring:
                    return "Весна";
                case season.Summer:
                    return "Лето";
                case season.Autumn:
                    return "Осень";
                default: return "";
            }
        }
        enum season { NaN, Winter, Spring, Summer, Autumn }
        static season OfMonth(int value)
        {
            try
            {
                if (value <= 0 || value > 12)
                    throw new Exception("Ошибка: введите число от 1 до 12");
                switch ((value % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.NaN;
            }
        }
    }
}
