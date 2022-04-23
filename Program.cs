using System;

namespace NLab4_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tМикрохвильовка:");
            Microwave mw = new Microwave(2.5);
            Console.WriteLine(mw.GetInfo());
            mw.ReplaceTo("Горище");
            mw.TurnOn();
            Console.WriteLine(mw.GetInfo() + "\n");

            Console.WriteLine("\tВилка:");
            Fork fr = new Fork(0.1);
            Console.WriteLine(fr.GetInfo());
            fr.Eat();
            fr.ReplaceTo("Вітальня");
            Console.WriteLine(fr.GetInfo() + "\n");
        }
    }
}
