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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {

        private string Entree;
        private string Side;
        private string Drink;

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(string entree)
        {
            this.Entree = entree;
            InitializeComponent();
            this.EntreeButton.Content = Entree;
        }

        private void Entree_click(object sender, RoutedEventArgs args)
        {
            this.EntreeButton.Content = NavigationService.Navigate(new EntreeSelection());
        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            this.SideButton.Content = NavigationService.Navigate(new SideSelection());
        }


        private void Drink_Click(object sender, RoutedEventArgs e)
        {
           this.DrinkButton.Content = NavigationService.Navigate(new DrinkSelection());
        }

        
    }
}
