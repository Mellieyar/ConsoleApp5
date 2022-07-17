using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    enum Figures { Romb, Circle, Rect }

    struct Fdata
    {
        public int x0, y0;      // координаты центра тяжести
        public int color;       // цвет фигуры
        public Figures type;	// тип фигуры
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Fdata fd;
            fd.x0 = 1;
            fd.y0 = 1;
            fd.color = 0x2727FF;
            fd.type = Figures.Romb;

            Fdata fd2 = new Fdata() { x0 = 2, y0 = 2, color = 0xFFFFFF, type = Figures.Circle };

            Console.WriteLine("Structure fd:");
            Console.WriteLine($"x0={fd.x0}");
            Console.WriteLine($"y0={fd.y0}");
            Console.WriteLine($"color={fd.color}");
            Console.WriteLine($"type={fd.type}");


            Console.ReadLine();
        }
    }
}
