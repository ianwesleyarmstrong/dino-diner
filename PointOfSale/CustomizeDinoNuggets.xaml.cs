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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets dn;
        /// <summary>
        /// no arg constructor
        /// </summary>
        public CustomizeDinoNuggets()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1 arg constructor
        /// </summary>
        /// <param name="dn"></param>
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            this.dn.AddNugget();
        }
    }
}
