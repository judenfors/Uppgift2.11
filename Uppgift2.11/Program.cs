using System;

namespace Uppgift2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin?");
            string längdText=Console.ReadLine();
            double längd = double.Parse(längdText);
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string längd2Text=Console.ReadLine();
            double längd2=double.Parse(längd2Text);
            double skillnad = längd - längd2;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre än Alma");
        }
    }
}