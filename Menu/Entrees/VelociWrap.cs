using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, IMenuItem
    {

        public bool dressing = true;
        public bool lettuce = true;
        public bool cheese = true;

        

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>()
                {
                    "Flour Tortilla",
                    "Chicken Breast",
                };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;

            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }

    }
}
