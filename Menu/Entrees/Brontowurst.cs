using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Brontowurst : Entree, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onion = true;

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
        /// provides special instructions for order
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onion) special.Add("Hold Onion");
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
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onion) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// public constructor
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// method to hold bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to hold peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to hold onions
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// override of default to string implementation
        /// </summary>
        /// <returns> string describing brontowurst </returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
