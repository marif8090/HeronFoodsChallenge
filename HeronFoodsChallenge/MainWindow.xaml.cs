using CSVApplication;
using CSVApplication.Features;
using CSVDataAccess.Entities;
using HeronFoodsChallenge.BL;
using HeronFoodsChallenge.ChildWindows;
using Microsoft.Win32;
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

namespace HeronFoodsChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       private List<Product> products;  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == true)
            {             
                string filename = openFileDialog.FileName;
                CSVLoader csvLoader = new CSVLoader();
                products = csvLoader.ReadCSV(filename).ToList();
                ListViewEditProducts.ItemsSource = products;
            }
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                SaveCSVFile saveCSVFile =  new SaveCSVFile();
                saveCSVFile.SaveCSV(products, saveFileDialog.FileName);
            }
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewEditProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdVBarodeCol.Width = Double.NaN;
        }

        private void BtnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            Product rowEntity = ((Button)e.OriginalSource).DataContext as Product;
            if (rowEntity != null)
            { 
                products.Remove(rowEntity);
                ListViewEditProducts.ItemsSource = null;
                ListViewEditProducts.ItemsSource = products;
            }
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductWindow addProduct = new ProductWindow();
            addProduct.DataAdded += Product_DataAdded;
            addProduct.Show();
        }

        private void BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            Product rowEntity = ((Button)e.OriginalSource).DataContext as Product;
            if (rowEntity != null)
            {
                ProductWindow addProduct = new ProductWindow(rowEntity);
                addProduct.DataChanged += Product_DataChanged;
                addProduct.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to edit");
            }
        }

        private void Product_DataChanged(object sender, EventArgs e)
        {
            Product productchanged = (Product)sender;
            if (productchanged != null)
            {
                 UpdateProduct(productchanged);
            }
        }
        private void Product_DataAdded(object sender, EventArgs e)
        {
            Product productAdded = (Product)sender;
            if (productAdded != null)
            {
                AddProduct(productAdded);
            }
        }

        private void UpdateProduct(Product product)
        {
            bool resultBcdoeExit = DataValidation.IsBarcodeExsit(products,product);
            if (resultBcdoeExit)
            {
                MessageBox.Show("Product barcode already exist, please check and change");
            }
            else
            {
                int index = products.IndexOf(products.Single(s => s.ProductCode == product.ProductCode));
                products.Remove(products.Single(s => s.ProductCode == product.ProductCode));
                products.Insert(index, product);
                ListViewEditProducts.ItemsSource = null;
                ListViewEditProducts.ItemsSource = products;
            }
        }
        private void AddProduct(Product product)
        {
            if (DataValidation.IsBarcodeExsit(products, product))
            {
                MessageBox.Show("Product barcode already exist, please check and try again");
                return;
            }
            else if(DataValidation.IsProductCodeExsit(products, product))
            {
                    MessageBox.Show("Product code already exist, please check and try again");
                    return;
            }
            else
            {
                products.Insert(0, product);
                ListViewEditProducts.ItemsSource = null;
                ListViewEditProducts.ItemsSource = products;
            }
        }
    }
}
