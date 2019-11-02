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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// private backing burger
        /// </summary>
        private SteakosaurusBurger sb;

        /// <summary>
        /// no arg constructor
        /// </summary>
        public CustomizeSteakosaurusBurger()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1 arg constructor
        /// </summary>
        /// <param name="sb"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        /// <summary>
        /// click to hold bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            this.sb.HoldBun();
        }

        /// <summary>
        /// click to hold ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            this.sb.HoldKetchup();
        }

        /// <summary>
        /// click to hold mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            this.sb.HoldMustard();
        }

        /// <summary>
        /// click to hold pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            this.sb.HoldPickle();
        }
    }
}
