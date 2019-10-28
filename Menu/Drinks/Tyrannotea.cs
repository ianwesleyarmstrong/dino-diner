using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variables for properties
        /// </summary>
        private double price;
        private Size size;
        private bool ice;
        private bool sweet;
        private bool lemon;

        /// <summary>
        /// provides description of tyronnotea. similar to ToString method.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// provides special instructions for preperation of beverage
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
        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;
            Ice = true;
        }

        /// <summary>
        /// property to determine if sugar is present in the drink
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
                if (sweet)
                {
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 16;
                            break;
                        case Size.Medium:
                            Calories = 32;
                            break;
                        case Size.Large:
                            Calories = 64;
                            break;
                    }
                }
                else if (!sweet)
                {
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 8;
                            break;
                        case Size.Medium:
                            Calories = 16;
                            break;
                        case Size.Large:
                            Calories = 32;
                            break;
                    }
                }
            }
        }
        
        /// <summary>
        /// property for lemon in drink
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
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
                if (Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }
                return ingredients;
            }
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
        /// method to add lemon
        /// </summary>
        public void AddLemon()
        {
            lemon = true;
            NotifyOfPropertyChange("Special");
            
        }

        /// <summary>
        /// override of ToString method
        /// </summary>
        /// <returns> string describing tyrannotea </returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{Size} Sweet Tyrannotea";
            }
            else
            {
                return $"{size} Tyrannotea";
            }
        }
    }
}
