using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Drink : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public abstract double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

        public abstract void HoldIce();

        /// <summary>
        /// Abstract method for to string
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();

        /// <summary>
        /// abstract method for description (similar to ToString())
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// abstract method for special instructions for drink
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// returns the item after changing its size
        /// </summary>
        /// <returns> a drink </returns>
        public abstract Drink Medium();
        /// <summary>
        /// returns the item after changing its size
        /// </summary>
        /// <returns> a drink </returns>
        public abstract Drink Large();


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
