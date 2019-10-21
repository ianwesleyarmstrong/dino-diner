using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PlesisiosaurusPattie : Entree
    {
        private bool bun = true;
        private bool mayo = true;
        private double price;
        private uint calories;
        
       public PlesisiosaurusPattie()
        {
            Price = 5.50;
            Calories = 487;
            Ingredients = new List<string>()
            {
                "fish Pattie",
                "Whole Wheat Bun",
                "Mayonaise"
            };
        }
}
