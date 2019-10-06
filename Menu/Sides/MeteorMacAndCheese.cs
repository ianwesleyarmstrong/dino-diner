using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MeteorMacAndCheese : Side, IMenuItem
    {
        private Size size;
        /// <summary>
        /// List of ingredients used in the Meteor Mac and Cheese
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Macaroni Noodles");
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Pork Sausage");
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
                
            
        }

        /// <summary>
        ///  Creates a new instance of Meteor Mac and Cheese.
        /// </summary>
        /// <param name="orderSize"> The size they would like to order </param>
        public MeteorMacAndCheese(Size orderSize)
        {
            this.size = orderSize;
            this.Price = 0.99;
            this.Calories = 420;

        }

        public MeteorMacAndCheese()
        {
            this.size = Size.Small;
            this.Price = 0.99;
            this.Calories = 420;

        }

        public override string ToString()
        {
            return $"{Size} Meteor Mac and Cheese";
        }
    }
}
