using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variables for properties
        /// </summary>
        private SodasaurusFlavor flavor;
        private double price;
        private Size size;
        private bool ice = true;

        /// <summary>
        /// public constructors
        /// </summary>
        public Sodasaurus()
        {
            Flavor = SodasaurusFlavor.Cola;
            Size = Size.Small;
        }

        /// <summary>
        /// provides description of sodasaurus. similar to ToString().
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
                if (!ice) special.Add("Hold Ice");
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
        /// property for flavor of sodausurus beverage
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// property for price of beverage
        /// </summary>
        public override double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }

        /// <summary>
        /// property to determine if ice should be included in the drink
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// property for size of beverage
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// property for ingredients of drink
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        /// <summary>
        /// method to hold ice
        /// </summary>
        public override void HoldIce()
        {
            NotifyOfPropertyChange("Special");
            ice = false;
        }

        /// <summary>
        /// override of ToString method
        /// </summary>
        /// <returns> string describing drink </returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sodasaurus";
        }
    }
}
