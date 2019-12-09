using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Triceritots : Side, IMenuItem, INotifyPropertyChanged
    {

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

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

        private Size size;
        /// <summary>
        /// List of ingredients used in the Triceratots.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Potato");
                Ingredients.Add("Salt");
                Ingredients.Add("Vegetable Oil");
                return Ingredients;
            }
        }

        /// <summary>
        /// Sets the appropriate calorie and price amounts for each size.
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
                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Create a new instance of Triceratots.
        /// </summary>
        /// <param name="orderSize"> The size they would like to order </param>
        public Triceritots(Size orderSize)
        {
            this.size = orderSize;
            this.Price = 0.99;
            this.Calories = 352;

        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Triceritots()
        {
            this.size = Size.Small;
            this.Price = 0.99;
            this.Calories = 352;
        }

        /// <summary>
        /// Changes the sideto size medium
        /// </summary>
        /// <returns></returns>
        public override Side Medium()
        {
            this.Size = Size.Medium;
            return this;
        }
        /// <summary>
        /// canges the side to size large
        /// </summary>
        /// <returns></returns>
        public override Side Large()
        {
            this.Size = Size.Large;
            return this;
        }

        /// <summary>
        /// override of default ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Triceritots";
        }
    }
}
