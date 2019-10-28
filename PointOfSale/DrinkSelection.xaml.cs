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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink Drink { get; set; }
      


        public DrinkSelection()
        {
            InitializeComponent();
            Lemon.IsEnabled = false;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = false;
        }

        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }

        public void AddSoda(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Sodasaurus());
            Lemon.IsEnabled = false;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = true;
            sweet.IsEnabled = false;
        }

        public void AddTea(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Tyrannotea());
            Lemon.IsEnabled = true;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = true;
        }

        public void AddCoffee(object sender, RoutedEventArgs args)
        {
            SelectDrink(new JurassicJava());
            Lemon.IsEnabled = false;
            decaf.IsEnabled = true;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = true;
        }

        public void AddWater(object sender, RoutedEventArgs args)
        {
            SelectDrink(new Water());
            Lemon.IsEnabled = true;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = false;
        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            FlavorSelection FlavorSel = new FlavorSelection
            {
                selection = this
            };
            NavigationService.Navigate(FlavorSel);
            
        }

        public void OnLemon(object sender, RoutedEventArgs args)
        {
           if (this.Drink is Tyrannotea tea)
            {
                Tyrannotea t = tea;
                t.AddLemon();
                this.Drink = t;
            }
           else if (this.Drink is Water water)
            {
                Water w = water;
                w.AddLemon();
                this.Drink = w;
            }
        }

        public void OnSweet(object sender, RoutedEventArgs args)
        {
           if (this.Drink is Tyrannotea tea)
            {
                Tyrannotea t = tea;
                t.Sweet = true; ;
                this.Drink = t;
            }
           if (this.Drink is JurassicJava java)
            {
                java.Sweet = true;
                this.Drink = java;
            }
        }

        public void OnDecaf(object sender, RoutedEventArgs args)
        {
           if (this.Drink is JurassicJava java)
           {
                JurassicJava j = java;
                j.Decaf = true;
                this.Drink = j;
           }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (this.Drink != null)
            {
                this.Drink.Size = size;
            }
        }

        private void SelectDrink(DinoDiner.Menu.Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(drink);
                this.Drink = drink;
            }
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        public void DoneClick(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }


    }
}
