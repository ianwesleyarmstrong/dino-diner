using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Fryceritops : Side, IMenuItem
    {
        private Size size;
        /// <summary>
        /// List of ingredients used in the Fryceritops
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Potato");
                Ingredients.Add("Salt");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate calorie and price amounts for each size.
        /// </summary>
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of Fryceritops.
        /// </summary>
        /// <param name="orderSize"> The size they would like to order </param>
        public Fryceritops(Size orderSize)
        {
            this.size = orderSize;
            this.Price = 0.99;
            this.Calories = 222;
        }

        public Fryceritops()
        {
            this.size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;
        }

        public override string ToString()
        {
            return $"{Size} Fryceritops";
        }
    }
}
