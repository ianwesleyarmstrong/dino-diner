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
    /// Interaction logic for CustomizePterodactylWings.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// private backing variable
        /// </summary>
        private VelociWrap vw;
        /// <summary>
        /// no arg constructor
        /// </summary>
        public CustomizeVelociWrap()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 1 arg constructor
        /// </summary>
        /// <param name="vw"></param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        /// <summary>
        /// click to hold dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            this.vw.HoldDressing();
        }

        /// <summary>
        /// click to hold lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            this.vw.HoldLettuce();
        }

        /// <summary>
        /// click to hold cheese
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            this.vw.HoldCheese();
        }


    }
}
