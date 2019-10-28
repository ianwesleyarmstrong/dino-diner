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
        /// backing variable for list of items
        /// </summary>
        private ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// getter/setter for items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
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
        public void AddItem(IOrderItem i)
        {
            Items.Add(i);
            
        }

        /// <summary>
        /// public constructor
        /// </summary>
        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
            //AddItem(new SteakosaurusBurger());
            //AddItem(new Fryceritops());
            //Triceritots t = new Triceritots();
            //AddItem(t);
            //t.Size = Size.Large;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
