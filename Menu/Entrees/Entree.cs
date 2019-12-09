using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public abstract override string ToString();

        public abstract string Description { get; }

        public abstract string[] Special { get; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
