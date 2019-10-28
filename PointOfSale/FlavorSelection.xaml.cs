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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public DrinkSelection selection { get; set; }
        public SodasaurusFlavor Flavor { get; set; }
        public FlavorSelection()
        {
            InitializeComponent();
        }

        public void DoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void SelectFlavor(SodasaurusFlavor flavor)
        {
            Sodasaurus s = new Sodasaurus();
            s.Flavor = flavor;
            selection.Drink = s;
            NavigationService.Navigate(selection);
        }

        public void OnCherry(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        public void OnCola(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        public void OnRootBeer(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }

        public void OnChocolate(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        public void OnLime(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        public void OnVanilla(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
        }
        public void OnOrange(object sender, RoutedEventArgs args)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }
    }
}
