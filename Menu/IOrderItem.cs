using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Information about the item
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Any special instructions for item (hold bun/hold mayo)
        /// </summary>
        string[] Special { get; }
    }
}
