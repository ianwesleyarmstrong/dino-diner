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
                order.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                Brontowurst b = new Brontowurst();
                order.Add(b);
                this.Entree = b;
                NavigationService.Navigate(new CustomizeBrontowurst(b));
            }
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets d = new DinoNuggets();
                order.Add(d);
                this.Entree = d;
                NavigationService.Navigate(new CustomizeDinoNuggets(d));
            }
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger s = new SteakosaurusBurger();
                order.Add(s);
                this.Entree = s;
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(s));
            }
        }

        public void AddVelociwrap(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap v = new VelociWrap ();
                order.Add(v);
                this.Entree = v;
                NavigationService.Navigate(new CustomizeVelociWrap(v));
            }
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger t = new TRexKingBurger();
                order.Add(t);
                this.Entree = t;
                NavigationService.Navigate(new CustomizeTRexKingBurger(t));
            }
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings p = new PterodactylWings();
                order.Add(p);
                this.Entree = p;
            }
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ p = new PrehistoricPBJ();
                order.Add(p);
                this.Entree = p;
                NavigationService.Navigate(new CustomizePBJ(p));
            }
        }
    }
}
