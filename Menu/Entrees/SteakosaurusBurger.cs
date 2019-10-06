using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree, IMenuItem
    {
        public bool bun = true;
        public bool pickle = true;
        public bool ketchup = true;
        public bool mustard = true;


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Steakburger Pattie"
                };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;

            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
