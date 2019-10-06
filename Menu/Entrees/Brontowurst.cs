using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, IMenuItem
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

        

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
