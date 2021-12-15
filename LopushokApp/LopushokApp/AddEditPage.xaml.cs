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
using System.Windows.Shapes;

namespace LopushokApp
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Window
    {
        private products _currentProduct = new products();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentProduct;
            TypesCombobox.ItemsSource = user10Entities.GetContext().ProductsTypes.ToList();
    }
        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
                if (_currentProduct.ProductID == null)
            {
                user10Entities.GetContext().products.Add(_currentProduct);
            }

            try
                {
                    user10Entities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }            
        }
    }
}
