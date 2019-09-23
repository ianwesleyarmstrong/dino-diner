using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {

        private Size size;
        /// <summary>
        /// List of ingredients used in the Mezzorella Sticks.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Breading");
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
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }


        /// <summary>
        ///  Creates a new instance of Mezzorella Sticks.
        /// </summary>
        /// <param name="orderSize"> The size they would like to order </param>
        public MezzorellaSticks(Size orderSize = Size.Small)
        {
            this.size = orderSize;
            this.Price = 0.99;
            this.Calories = 540;
        }

    }
}
