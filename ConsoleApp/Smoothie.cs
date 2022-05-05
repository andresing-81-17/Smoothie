using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Smoothie
    {
        public Smoothie (string[] ingredients)
        {
            this.ingredients = ingredients;
        }

        static Dictionary<string, string> prices = new Dictionary<string, string>()
        {
            { "Strawberries", "$1.50" },
            { "Banana", "$0.50" },
            { "Mango", "$2.50" },
            { "Blueberries", "$1.00" },
            { "Raspberries", "$1.00" },
            { "Apple", "$1.75" },
            { "Pineapple", "$3.50" }          

        };
        private readonly string[] ingredients;

        public string[] Ingredients 
        {           
            get { return this.ingredients; }
            set { this.Ingredients = value; }    
            
        }

        public string GetCost()
        {
            double coste = 0;
            foreach (string ingredient in this.ingredients)
            {
                if (Smoothie.prices.ContainsKey(ingredient))
                {
                    
                    var valueDict = Smoothie.prices[ingredient];                    
                    var removerSing = valueDict.Replace("$", "");
                    var valuePrice = double.Parse(removerSing);

                    coste += valuePrice;
                }
            }
            return coste.ToString("C", CultureInfo.CurrentCulture);
        }

        public string GetPrice()
        {
            var valuePrice = this.GetCost();
            var removerSing = valuePrice.Replace("$", "");
            var getPrice = Math.Round((double.Parse(removerSing) * 2.5),2).ToString("C", CultureInfo.CurrentCulture);
            return getPrice;
        }

        public string GetName()
        {
            List<string> names = new List<string>();
            foreach (var item in this.ingredients)
            {
                if (item.Length > 9)
                {
                    if (item.Substring(item.Length - 7) == "berries")
                    {
                        names.Add(item.Replace( "ies","y"));
                    }
                    else
                    {
                        names.Add(item);
                    }
                }
                else 
                {
                    names.Add(item);
                }
            }

            if (names.Count < 2)
            {
                names.Add("Smoothie");

            }
            else
            {
                names.Sort();
                names.Add("Fusion");
            }
            return string.Join(" ",names);
        }

    }
}
