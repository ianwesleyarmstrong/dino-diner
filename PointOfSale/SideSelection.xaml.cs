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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// public side 
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// previous customize combo page
        /// </summary>

        private CustomizeCombo customizeComboPage;

        private bool isPartOfCombo;

        /// <summary>
        /// no arg constructor
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1 arg constructor
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            DataContext = side;
            this.Side = side;
        }

        /// <summary>
        /// constructor used by combo pages
        /// </summary>
        /// <param name="side"></param>
        /// <param name="isPartOfCombo"></param>
        /// <param name="comboPage"></param>
        public SideSelection(Side side, bool isPartOfCombo, CustomizeCombo comboPage)
        {
            InitializeComponent();
            this.isPartOfCombo = isPartOfCombo;
            this.customizeComboPage = comboPage;
            if (this.isPartOfCombo)
            {
                this.customizeComboPage.Combo.Side = side;
                Side = customizeComboPage.Combo.Side;
            }
            else
                Side = side;

        }

        /// <summary>
        /// adds new fryceritops to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddFryceritiops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// adds triceritots to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// adds mac and cheese to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        /// <summary>
        /// adds mezzorella sticks to order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }


        /// <summary>
        /// helper function to add side
        /// </summary>
        /// <param name="side"></param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (isPartOfCombo)
                {
                    customizeComboPage.Combo.Side = side;
                    Side = customizeComboPage.Combo.Side;
                    NotifyOfPropertyChange("Special");
                    NotifyOfPropertyChange("Price");
                }
                else
                {
                    order.Add(side);
                    this.Side = side;
                }
               
            }

        }

        /// <summary>
        /// helper function to set size
        /// </summary>
        /// <param name="size"></param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (this.Side != null)
            {
                this.Side.Size = size;
                NotifyOfPropertyChange("Price");
                if (isPartOfCombo)
                {
                    NotifyOfPropertyChange("Special");
                }
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                    NavigationService.Navigate(new MenuCategorySelection());
            }
            
        }

        /// <summary>
        /// changes selected side's size to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// changes selected side's size to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// changes selected side's size to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        /// <summary>
        /// notifies combo page of changes that need to be rendered
        /// </summary>
        /// <param name="property"></param>
        public void NotifyOfPropertyChange(string property)
        {
            customizeComboPage.Combo.NotifyOfPropertyChange(property);
        }

       

    }
}
