using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class VelociWrap : Entree, IMenuItem, INotifyPropertyChanged
    {
        // backing variables
        public bool dressing = true;
        public bool lettuce = true;
        public bool cheese = true;

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
        /// provides special instructions for item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
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

        /// <summary>
        /// public constructor
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// method to hold dressing
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to hold lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to hold cheese
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// override of default ToString
        /// </summary>
        /// <returns> name of item </returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

    }
}
