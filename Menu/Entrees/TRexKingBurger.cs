using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        public bool bun = true;
        public bool pickle = true;
        public bool ketchup = true;
        public bool mustard = true;
        public bool mayo = true;
        public bool lettuce = true;
        public bool tomato = true;
        public bool onion = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>
                {
                    "Steakburger Patty"
                };
                if (bun) ingredients.Add("Whole Wheat Bub");
                if (pickle) ingredients.Add("Pickles");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                return ingredients;

            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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

        public void HoldMayo()
        {
            this.mayo = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

    }
}
