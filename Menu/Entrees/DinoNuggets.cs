using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private int numNuggets = 6;
        private int additionalNuggets = 0;

        /// <summary>
        /// provides description of brontowurst
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// special instructions for order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (additionalNuggets > 0) special.Add($"{additionalNuggets} Extra Nuggets");
                return special.ToArray();
            }
        }

        /// <summary>
        /// PropertyChanged event handler; notifies
        /// of changes to the Price, Description, nad 
        /// Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// helper funtion to notify of property changes
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// property for ingredients
        /// </summary>
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

        /// <summary>
        /// public constructor
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 6 * 59;
        }

        /// <summary>
        /// method to add a nugget to the order
        /// </summary>
        public void AddNugget()
        {
            this.additionalNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
        }

        /// <summary>
        /// override of default to string method
        /// </summary>
        /// <returns> string describing order </returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
    

