using System;

namespace NLab4_Interface
{
    abstract class Dishes : IUseDishes, IPlace
    {
        private double weight;
        private bool contaminated; // забруднено
        private string place = "Кухня";

        public double Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }

        public Dishes() { }
        public Dishes(double weight) { this.weight = weight; }

        public void Eat()
        { contaminated = true; }
        public void Wash()
        { contaminated = false; }
        public void ReplaceTo(string s)
        { place = s; }
        public string GetInfo()
        {
            Console.WriteLine($"Знаходиться у: {place}");
            if (contaminated == true)
                return "Посуд брудний";
            else
                return "Посуд чистий";
        }
    }
}