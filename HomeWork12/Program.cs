using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи\n" +
                "1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:" +
                "\r\nметод, определяющий длину окружности по заданному радиусу;" +
                "\r\nметод, определяющий площадь круга по заданному радиусу;" +
                "\r\nметод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.\r\n");
            Console.Write("r=");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y=");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"l={Round.Get_l(r)}");
            Console.WriteLine($"l={Round.Get_s(r)}");
            if (Round.Get_isIn(r, x, y)) Console.WriteLine("Точка в круге");
            else Console.Write("точка за кругом");

            Console.ReadKey();
        }
    }
}
