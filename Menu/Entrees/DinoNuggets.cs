using System.Collections.Generic;
using System;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, IMenuItem
    {
        private int numNuggets = 6;
        private int additionalNuggets = 0;


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                for (int i = 0; i < additionalNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        public void AddNugget()
        {
            this.additionalNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }

        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
    

