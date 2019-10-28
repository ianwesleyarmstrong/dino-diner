using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PlesisiosaurusPattie : Entree
    {
        private bool bun = true;
        private bool mayo = true;
        private List<string> ingredients;


        /// <summary>
        /// provides description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// special instructions needed for item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
        public PlesisiosaurusPattie()
        {
            Price = 5.50;
            Calories = 487;
            ingredients = new List<string>{
                    "Fish Pattie",
                    "Whole Wheat Bun",
                    "Mayonaise"
                };
        }

        public void HoldBun()
        {
            this.bun = false;
            Ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldMayo()
        {
            this.mayo = false;
            Ingredients.Remove("Mayonnaise");
        }

        public override List<String> Ingredients
        {
            get
            {
                return new List<string>(ingredients);
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
