using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    class CretaceousCombo
    {
        public Size size;
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;

            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            //Side = new Fryceritops();
            //Drink = new Sodasaurus();
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
