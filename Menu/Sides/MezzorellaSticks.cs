using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// 
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

        private Size size;
        /// <summary>
        /// List of ingredients used in the Mezzorella Sticks.
        /// </summary>
        public override List<String> Ingredients
        {
            get
            {
                List<string> Ingredients = new List<string>();
                Ingredients.Add("Cheese Product");
                Ingredients.Add("Breading");
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }


        /// <summary>
        ///  Creates a new instance of Mezzorella Sticks.
        /// </summary>
        /// <param name="orderSize"> The size they would like to order </param>
        public MezzorellaSticks(Size orderSize)
        {
            this.size = orderSize;
            this.Price = 0.99;
            this.Calories = 540;
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public MezzorellaSticks()
        {
            this.size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;
        }

        /// <summary>
        /// override of default ToString 
        /// </summary>
        /// <returns> name of item </returns>
        public override string ToString()
        {
            return $"{size} Mezzorella Sticks";
        }

    }
}
