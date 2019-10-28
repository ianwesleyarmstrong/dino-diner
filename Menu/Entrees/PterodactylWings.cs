using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class PterodactylWings : Entree, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// provides description of item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// special instructions for item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
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
                ingredients.Add("Chicken");
                ingredients.Add("Wing Sauce");
                return ingredients;

            }
        }

        /// <summary>
        /// public constructor
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// override of default ToString
        /// </summary>
        /// <returns> name of item </returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
    