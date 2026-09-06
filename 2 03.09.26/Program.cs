using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03._09._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите возраст ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("выберите тип билета: 1 - обычный, 2 - студенческий, 3 - VIP.");
            int ticket = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите день недели ");
            int weekday = Convert.ToInt32(Console.ReadLine());

            int price;
            string ticketName;
            switch (ticket)
            {
                case 1:
                    ticketName = ("обычный ");
                    price = 500;
                    break;
                case 2:
                    ticketName = ("студенческий ");
                    price = 350;
                    break;
                case 3:
                    ticketName = ("VIP ");
                    price = 1000;
                    break;
                default:
                    Console.WriteLine("Неверный выбор (должно быть 1, 2 или 3)");
                    return;
            }
            double finalprice = price;
            string discountText = "нет";

            if (age < 18)
            {
                finalprice = finalprice * 0.80;
                discountText = "да ";
            }
            else if (age >= 60)
            {
                finalprice = finalprice * 0.70;
                discountText = "да ";
            }
            bool weekend = (weekday == 6 || weekday == 7);
            string weekendtext = weekend ? "да" : "нет";

            finalprice = weekend ? finalprice * 1.10 : finalprice;

            Console.WriteLine($"тип билета: {ticketName} ");
            Console.WriteLine($"возрастная скидка: {discountText}");
            Console.WriteLine($"выходной день: {weekendtext}");
            Console.WriteLine($"итоговая стоимость: {finalprice:F0}");
        }
    }
}
