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
        /// <summary>
        /// Drink to be modified
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// previous combo page
        /// </summary>
        private CustomizeCombo customizeComboPage;

        private FlavorSelection flavorSelectionPage;

        private bool isPartOfCombo;

        /// <summary>
        /// no arg construcor
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            Lemon.IsEnabled = false;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = false;
            Ice.IsEnabled = false;
            Cream.IsEnabled = false;
        }

        /// <summary>
        /// 3 arg construcot
        /// </summary>
        public DrinkSelection(Drink drink, bool combo, CustomizeCombo comboPage)
        {
            InitializeComponent();
            this.isPartOfCombo = combo;
            this.customizeComboPage = comboPage;
            if (this.isPartOfCombo)
            {
                this.customizeComboPage.Combo.Drink = drink;
                Drink = customizeComboPage.Combo.Drink;
            }
            if (drink is Sodasaurus)
            {
                Lemon.IsEnabled = false;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = true;
                sweet.IsEnabled = false;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
            else if (drink is Tyrannotea)
            {
                Lemon.IsEnabled = true;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = true;
                sweet.IsEnabled = true;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
            else if (drink is JurassicJava)
            {
                Lemon.IsEnabled = false;
                decaf.IsEnabled = true;
                Flavor.IsEnabled = false;
                sweet.IsEnabled = true;
                Ice.IsEnabled = true;
                Cream.IsEnabled = true;

            }
            else if (drink is Water)
            {
                Lemon.IsEnabled = true;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = false;
                sweet.IsEnabled = false;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
        }
    

        /// <summary>
        /// 1 arg constructor
        /// </summary>
        /// <param name="drink"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
            if (drink is Sodasaurus)
            {
                Lemon.IsEnabled = false;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = true;
                sweet.IsEnabled = false;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
            else if (drink is Tyrannotea)
            {
                Lemon.IsEnabled = true;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = true;
                sweet.IsEnabled = true;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
            else if (drink is JurassicJava)
            {
                Lemon.IsEnabled = false;
                decaf.IsEnabled = true;
                Flavor.IsEnabled = false;
                sweet.IsEnabled = true;
                Ice.IsEnabled = true;
                Cream.IsEnabled = true;

            }
            else if (drink is Water)
            {
                Lemon.IsEnabled = true;
                decaf.IsEnabled = false;
                Flavor.IsEnabled = false;
                sweet.IsEnabled = false;
                Ice.IsEnabled = true;
                Cream.IsEnabled = false;
            }
        }

        /// <summary>
        /// adds a sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddSoda(object sender, RoutedEventArgs e)
        {
            if (isPartOfCombo)
            {
                customizeComboPage.Combo.Drink = new Sodasaurus();
                Drink = customizeComboPage.Combo.Drink;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                SelectDrink(new Sodasaurus());
            }
            Lemon.IsEnabled = false;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = true;
            sweet.IsEnabled = false;
            Ice.IsEnabled = true;
            Cream.IsEnabled = false;
        }

        public void AddTea(object sender, RoutedEventArgs args)
        {
            if (isPartOfCombo)
            {
                customizeComboPage.Combo.Drink = new Tyrannotea();
                Drink = customizeComboPage.Combo.Drink;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                SelectDrink(new Tyrannotea());
            }
            Lemon.IsEnabled = true;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = true;
            sweet.IsEnabled = true;
            Ice.IsEnabled = true;
            Cream.IsEnabled = false;
        }

        public void AddCoffee(object sender, RoutedEventArgs args)
        {
            if (isPartOfCombo)
            {
                customizeComboPage.Combo.Drink = new JurassicJava();
                Drink = customizeComboPage.Combo.Drink;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                SelectDrink(new JurassicJava());
            }
            Lemon.IsEnabled = false;
            decaf.IsEnabled = true;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = true;
            Ice.IsEnabled = true;
            Cream.IsEnabled = true;
        }

        public void AddWater(object sender, RoutedEventArgs args)
        {
            if (isPartOfCombo)
            {
                customizeComboPage.Combo.Drink = new Water();
                Drink = customizeComboPage.Combo.Drink;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
            else
            {
                SelectDrink(new Water());
            }
            Lemon.IsEnabled = true;
            decaf.IsEnabled = false;
            Flavor.IsEnabled = false;
            sweet.IsEnabled = false;
            Ice.IsEnabled = true;
            Cream.IsEnabled = false;
        }

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            FlavorSelection FlavorSel = new FlavorSelection();
            FlavorSel.selection = this;
            NavigationService.Navigate(FlavorSel);
            if (isPartOfCombo)
            {
                NotifyOfPropertyChange("Special");
            }
            
        }

        public void OnLemon(object sender, RoutedEventArgs args)
        {
           if (this.Drink is Tyrannotea tea)
            {
                if (tea.Lemon == false)
                {
                    tea.AddLemon();
                    this.Drink = tea;
                }
                else
                {
                    tea.Lemon = false;
                    this.Drink = tea;
                }
                
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
                if (t.Sweet == false)
                {
                    t.Sweet = true;
                    this.Drink = t;
                }
                else
                {
                    t.Sweet = false;
                    this.Drink = t;
                }
                
            }
           if (this.Drink is JurassicJava java)
            {
                if (java.Sweet == false)
                {
                    java.Sweet = true;
                    this.Drink = java;
                }
                else
                {
                    java.Sweet = false;
                    this.Drink = java;
                }
            }
        }


        public void OnIce(object sender, RoutedEventArgs args)
        {
            if (this.Drink is Sodasaurus soda)
            {
                if (soda.Ice == true)
                {
                    soda.HoldIce();
                    this.Drink = soda;
                }
                else
                {
                    soda.Ice = true;
                    this.Drink = soda;
                }
            }
            if (this.Drink is Tyrannotea tea)
            {
                if (tea.Ice == true)
                {
                    tea.HoldIce();
                    this.Drink = tea;
                }
                else
                {
                    tea.Ice = true;
                    this.Drink = tea;
                }
            }
            if (this.Drink is Water water)
            {
                if (water.Ice == true)
                {
                    water.HoldIce();
                    this.Drink = water;
                }
                else
                {
                    water.Ice = true;
                    this.Drink = water;
                }
            }
            if (this.Drink is JurassicJava java)
                if (java.Ice == true)
                {
                    java.HoldIce();
                    this.Drink = java;
                }
                else
                {
                    java.AddIce();
                    this.Drink = java;
                }
        }

        public void OnDecaf(object sender, RoutedEventArgs args)
        {
           if (this.Drink is JurassicJava java)
           {
                JurassicJava j = java;
                if (j.Decaf == false)
                {
                    j.Decaf = true;
                    this.Drink = j;
                }
                else
                {
                    j.Decaf = false;
                    this.Drink = j;
                }
           }
        }

        public void OnCream(object sender, RoutedEventArgs args)
        {
            if (this.Drink is JurassicJava java)
            {
                if (java.RoomForCream == false)
                {
                    java.LeaveRoomForCream();
                    this.Drink = java;
                }
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (this.Drink != null)
            {
                this.Drink.Size = size;
            }
            if (isPartOfCombo)
            {
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Price");
            }
        }

        private void SelectDrink(DinoDiner.Menu.Drink drink)
        {
            if (DataContext is Order order)
            {
                if (isPartOfCombo)
                {
                    customizeComboPage.Combo.Drink = drink;
                    this.Drink = customizeComboPage.Combo.Drink;
                }
                order.Add(drink);
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

        /// <summary>
        /// click to navigate back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DoneClick(object sender, RoutedEventArgs args)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// notifies combo if something has changed
        /// </summary>
        /// <param name="property"></param>
        public void NotifyOfPropertyChange(string property)
        {
            if (isPartOfCombo)
            {
                customizeComboPage.Combo.NotifyOfPropertyChange(property);
            }
        }


    }
}
