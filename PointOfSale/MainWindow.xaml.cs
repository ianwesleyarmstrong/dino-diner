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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderList.NavigationService = OrderInterface.NavigationService;
            Order order = (Order)DataContext;
        }


        /// <summary>
        /// Sets the data context for the order interface
        /// </summary>
        private void BindDataContextToPage()
        {
            if (OrderInterface.Content is FrameworkElement element)
            {
                element.DataContext = OrderInterface.DataContext;
            }
        }

        /// <summary>
        /// Sets data context when program loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            BindDataContextToPage();
        }

        /// <summary>
        /// Updates the data context when items are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            BindDataContextToPage();
        }

        public void OnDone(object sender, RoutedEventArgs args)
        {
            if (OrderInterface.CanGoBack)
                OrderInterface.NavigationService.GoBack();
            else
                OrderInterface.NavigationService.Navigate(new MenuCategorySelection());
        }
        
    }
}
