using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public abstract override string ToString();

    }
}
