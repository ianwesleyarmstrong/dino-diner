using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {

        private double price;
        private Size size;
        private bool ice;
        private bool sweet;
        private bool lemon;

        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;
            Ice = true;
        }

        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                if (sweet)
                {
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 16;
                            break;
                        case Size.Medium:
                            Calories = 32;
                            break;
                        case Size.Large:
                            Calories = 64;
                            break;
                    }
                }
                else if (!sweet)
                {
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 8;
                            break;
                        case Size.Medium:
                            Calories = 16;
                            break;
                        case Size.Large:
                            Calories = 32;
                            break;
                    }
                }
            }
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
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
                if (Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                return ingredients;
            }
        }

        public override void HoldIce()
        {
            ice = false;
        }

        public void AddLemon()
        {
            lemon = true;
        }
    }
}
