using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// private backing variable for properties
        /// </summary>
        private Size size;
        private double price;
        private bool ice;
        private bool decaf;
        private bool room;
        private bool sweet;

        /// <summary>
        /// information about the order used for data binding
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
                if (ice) special.Add("Add Ice");
                if (room) special.Add("Leave Room for Cream");
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
        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
            LeaveRoomForCream = false;
            Decaf = false;
        }

        /// <summary>
        /// method to leave room for cream at top of beverage
        /// </summary>
        public bool LeaveRoomForCream
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
                NotifyOfPropertyChange("Special");
            }

        }


        /// <summary>
        /// property for setting the status of ice in the beverage
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
                NotifyOfPropertyChange("Special");
            }
        }

        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// property for status of caffination
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// property for price of beverage. overriden from drink base class
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
        /// property for size. overriden from drink base class
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }
        /// <summary>
        /// property for ingredients of beverage
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                return ingredients;
            }
        }

        /// <summary>
        /// method to add ice to beverage
        /// </summary>
        public void AddIce()
        {
            ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// method to stop ice from being added.
        /// </summary>
        public override void HoldIce()
        {
            ice = false;
            NotifyOfPropertyChange("Special");
        }


        /// <summary>
        /// override of to string method
        /// </summary>
        /// <returns> string describing the beverage </returns>
        public override string ToString()
        {
            if (Decaf)
            {
                if (Sweet)
                {
                    return $"{Size} Sweet Decaf Jurassic Java";
                }
                else
                {
                    return $"{Size} Decaf Jurassic Java";
                }
            }
            else
            {
                if (Sweet)
                {
                    return $"{Size} Sweet Jurassic Java";
                }
                else
                {
                    return $"{Size} Jurassic Java";
                }
            }
        }
    }
}
