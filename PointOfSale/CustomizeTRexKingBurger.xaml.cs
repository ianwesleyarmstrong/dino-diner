using System;
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// private backing burger
        /// </summary>
        private TRexKingBurger tb;
        /// <summary>
        /// no arg constructor
        /// </summary>
        public CustomizeTRexKingBurger()
        {
            InitializeComponent();
        }

        public CustomizeTRexKingBurger(TRexKingBurger tb)
        {
            InitializeComponent();
            this.tb = tb;
        }

        /// <summary>
        /// click to hold bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            this.tb.HoldBun();
        }

        /// <summary>
        /// click to hold ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            this.tb.HoldKetchup();
        }

        /// <summary>
        /// click to hold mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            this.tb.HoldMustard();
        }

        /// <summary>
        /// click to hold pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            this.tb.HoldPickle();
        }

        /// <summary>
        /// click to hold mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            this.tb.HoldMayo();
        }

        /// <summary>
        /// click to hold lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            this.tb.HoldLettuce();
        }

        /// <summary>
        /// click to hold tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            this.tb.HoldTomato();
        }

        /// <summary>
        /// click to hold onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            this.tb.HoldOnion();
        }
    }
}
