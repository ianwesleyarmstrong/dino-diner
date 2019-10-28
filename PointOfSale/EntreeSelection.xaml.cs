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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {

        public Entree Entree { get; set; }

        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }

        private void AddEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            AddEntree(new Brontowurst());
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            AddEntree(new DinoNuggets());
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            AddEntree(new SteakosaurusBurger());
        }

        public void AddVelociwrap(object sender, RoutedEventArgs args)
        {
            AddEntree(new VelociWrap());
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            AddEntree(new TRexKingBurger());
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            AddEntree(new PterodactylWings());
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            AddEntree(new PrehistoricPBJ());
        }
    }
}
