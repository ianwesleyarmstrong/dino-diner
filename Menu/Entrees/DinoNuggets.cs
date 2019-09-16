using System.Collections.Generic;
using System;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private int numNuggets = 6;


        public double Price { get; set; }
        public uint Calories { get; set; }
            

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < numNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25 + ((numNuggets - 6) * 0.25);
            this.Calories = Convert.ToUInt32(numNuggets * 59);
        }

        public void AddNugget()
        {
            this.numNuggets += 1;
        }
    }
}
    

