using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem
    {
        private double price;
        private Size size;
        private bool ice;
     
        private bool lemon;

        public Water()
        {
            Size = Size.Small;
            Lemon = false;
            Ice = true;
        }


        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
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
                        Price = 0.1;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.1;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.1;
                        Calories = 0;
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
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                return ingredients;
            }
        }

        public void AddLemon()
        {
            lemon = true;
        }

        public override void HoldIce()
        {
            ice = false;
        }

        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}
