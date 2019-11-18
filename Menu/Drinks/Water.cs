using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private Size size;
        private bool ice;
        private bool lemon;

        /// <summary>
        /// describes the water beverage. similar to tostring
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// special instructions for preperation
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
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
        /// public constructor
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Lemon = false;
            Ice = true;
        }

        /// <summary>
        /// property for lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// property for price
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
        /// property for ice
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
        /// property for size
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
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Medium:
                        Price = 0.10;
                        Calories = 0;
                        break;
                    case Size.Large:
                        Price = 0.10;
                        Calories = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// property for ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// method to add lemon
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to hold ice
        /// </summary>
        public override void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// override of ToString method
        /// </summary>
        /// <returns> string describing the water </returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}
