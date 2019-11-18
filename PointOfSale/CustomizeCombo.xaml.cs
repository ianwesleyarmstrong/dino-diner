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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {

        public CretaceousCombo Combo { get; set; }

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(CretaceousCombo combo)
        {
            this.Combo = combo;
            InitializeComponent();
            UpdateButtons();            
        }

        private void Entree_click(object sender, RoutedEventArgs args)
        {
            if (Combo.Entree is Brontowurst b)
                NavigationService.Navigate(new CustomizeBrontowurst(b));
            else if (Combo.Entree is DinoNuggets d)
                NavigationService.Navigate(new CustomizeDinoNuggets(d));
            else if (Combo.Entree is PrehistoricPBJ p)
                NavigationService.Navigate(new CustomizePBJ(p));
            else if (Combo.Entree is SteakosaurusBurger s)
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(s));
            else if (Combo.Entree is TRexKingBurger t)
                NavigationService.Navigate(new CustomizeTRexKingBurger(t));
            else if (Combo.Entree is VelociWrap v)
                NavigationService.Navigate(new CustomizeVelociWrap(v));
        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(Combo.Side, true, this));
        }


        private void Drink_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new DrinkSelection(Combo.Drink, true, this));
        }


        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Small;
            UpdateButtons();
        }

        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Medium;
            UpdateButtons();
        }

        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            Combo.Size = DinoDiner.Menu.Size.Large;
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            DrinkButton.Content = Combo.Drink.Description;
            SideButton.Content = Combo.Side.Description;
            EntreeButton.Content = Combo.Entree.Description;
        }


        protected void OnPageLoaded(object sender, RoutedEventArgs args)
        {
            UpdateButtons();
        }

        
    }
}
