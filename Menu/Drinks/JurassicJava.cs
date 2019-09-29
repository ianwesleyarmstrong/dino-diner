using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {

        private Size size;
        private double price;
        private bool ice;
        private bool decaf;
        private bool room;

        public JurassicJava()
        {
            Size = Size.Small;
            Ice = false;
            LeaveRoomForCream = false;
            Decaf = false;
        }
        public bool LeaveRoomForCream
        {
            get
            {
                return room;
            }
            set
            {
                room = value;
            }

        }

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
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }

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

        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
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

        public void AddIce()
        {
            ice = true;
        }

        public override void HoldIce()
        {
            ice = false;
        }
    }
}
