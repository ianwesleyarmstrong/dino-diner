using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Order : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing variable for rate
        /// </summary>
        private double rate = .1;
        /// <summary>
        /// property for price
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// property for description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// property for special
        /// </summary>
        public string[] Special { get; }

        /// <summary>
        /// collection of items in the order
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// backing variable for list of items
        /// </summary>
        private IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        

        

        /// <summary>
        /// preliminary cost of items in the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double total = 0;
                foreach (IOrderItem i in Items)
                {
                    total += i.Price;
                }
                if (total < 0) return 0;
                else return total;
            }
        }

        /// <summary>
        /// getter/setter for sales tax
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value < 0) return;
                rate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            
        }

        /// <summary>
        /// getter for amount needed for sales tax
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// getter for the total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }

        /// <summary>
        /// adds each item to the order
        /// </summary>
        /// <param name="i"></param>
        public void Add(IOrderItem i)
        {
            items.Add(i);
            i.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
           
        }

        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="i"></param>
        public bool Remove(IOrderItem i)
        {
            bool flag = items.Remove(i);
            if (flag)
            {
                NotifyAllPropertiesChanged();
            }
            return flag;
        }

        /// <summary>
        /// public constructor
        /// </summary>
        public Order()
        {
            Add(new SteakosaurusBurger());
        }

       private void NotifyAllPropertiesChanged()
        {
            NotifyOfPropertyChanged("SubTotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("Items");
        }
        private void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {

        }
    }
}
