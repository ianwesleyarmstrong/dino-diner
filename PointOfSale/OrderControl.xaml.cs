﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        public NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                if (entree is PrehistoricPBJ p)
                    NavigationService?.Navigate(new CustomizePBJ(p));
                else if (entree is Brontowurst b)
                    NavigationService?.Navigate(new CustomizeBrontowurst(b));
                else if (entree is VelociWrap v)
                    NavigationService?.Navigate(new CustomizeVelociWrap(v));
                else if (entree is TRexKingBurger t)
                    NavigationService?.Navigate(new CustomizeTRexKingBurger(t));
                else if (entree is SteakosaurusBurger s)
                    NavigationService?.Navigate(new CustomizeSteakosaurusBurger(s));
                else if (entree is DinoNuggets d)
                    NavigationService?.Navigate(new CustomizeDinoNuggets(d));
                else
                    NavigationService?.Navigate(new EntreeSelection());
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeCombo());
            }
        }

        private void OnRemove(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

      
    }
}
