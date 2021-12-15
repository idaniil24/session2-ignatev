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

namespace LopushokApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var currentproducts = user10Entities.GetContext().products.ToList();            
            InitializeComponent();
            LWProducts.ItemsSource = currentproducts;
            ComboTypes.ItemsSource = user10Entities.GetContext().ProductsTypes.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage addEditPage = new AddEditPage();
            addEditPage.Show();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage addEditPage = new AddEditPage();
            addEditPage.Show();
        }
    }
}
