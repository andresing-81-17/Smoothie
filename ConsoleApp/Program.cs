using System;
using System.Globalization;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");
            
            Smoothie f1 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine("Smoothie #2");
            Console.Write("Smoothie Ingredients: ");
            Console.WriteLine("{{ {0} }}", string.Join(", ", f1.Ingredients));
            Console.Write("Smoothie Cost: ");
            Console.WriteLine("{0}", f1.GetCost());
            Console.Write("Smoothie Price: ");
            Console.WriteLine(f1.GetPrice());
            Console.Write("Smoothie Name: ");
            Console.WriteLine(f1.GetName());


            //Console.WriteLine("Hello World");

            //Tests test = new Tests();
            //test.Test1();


        }
    }
}
