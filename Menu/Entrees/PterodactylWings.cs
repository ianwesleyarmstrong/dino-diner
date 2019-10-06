using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, IMenuItem
    {
              

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;

            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
    