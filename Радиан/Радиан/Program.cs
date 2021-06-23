using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Радиан
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество градусов угла");
            string buf;
            buf = Console.ReadLine();
            double Grad;
            Grad = Convert.ToDouble(buf);
            Console.WriteLine("Введите количество минут угла");
            string min;
            min = Console.ReadLine();
            double Minutes;
            Minutes = Convert.ToInt32(min);
            Console.WriteLine("Введите количество секунд угла");
            string sec;
            sec = Console.ReadLine();
            double Seconds;
            Seconds = Convert.ToInt32(sec);
            double Radians = 0;
            Radians = (Grad + Minutes / 60 + Seconds / 3600) * (Math.PI) / 180;
            if (Grad < 0)
                Radians = -Radians;
            Console.WriteLine("Значение данного угла в радианах=" + Radians);
            Console.ReadKey();
        }
    }
}
