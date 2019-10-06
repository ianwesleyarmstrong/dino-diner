using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem
    {

        private SodasaurusFlavor flavor;
        private double price;
        private Size size;
        private bool ice = true;

        public Sodasaurus()
        {
            Flavor = SodasaurusFlavor.Cola;
            Size = Size.Small;
        }
            

        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        public override double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }

        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        public override void HoldIce()
        {
            ice = false;
        }

        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
