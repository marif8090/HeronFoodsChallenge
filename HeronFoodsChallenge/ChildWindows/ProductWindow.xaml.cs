using CSVDataAccess.Entities;
using HeronFoodsChallenge.BL;
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

namespace HeronFoodsChallenge.ChildWindows
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public delegate void DataChangedEventHandler(object sender, EventArgs e);

        public event DataChangedEventHandler DataChanged;
        public event DataChangedEventHandler DataAdded;

        public ProductWindow()
        {
            InitializeComponent();
            btnAddProduct.Visibility = Visibility.Visible;
            txtProductCode.IsEnabled = true;
        }

        public ProductWindow(Product product)
        {
            InitializeComponent();

            if (product != null)
            {
                txtProductCode.Text = product.ProductCode.ToString();
                txtProductDescription.Text = product.ProductDescription != null? product.ProductDescription.ToString() : "";
                RetailPriceIncVAT.Text = product.RetailPriceIncVAT.ToString();
                txtVATRate.Text = product.VATRate.ToString();
                txtBarcode.Text = product.Barcodes != null ? product.Barcodes.ToString() : "";
                btnUpdateProduct.Visibility = Visibility.Visible;
            }
        }

        private void BtnUpdateProduct_Click(object sender, RoutedEventArgs e)
        {

            DataChangedEventHandler handler = DataChanged;

            if (handler != null)
            {
                AddUpdateProductHandler(handler);
            }
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            DataChangedEventHandler handler = DataAdded;
            if (DataValidation.IsValidProductCode(txtProductCode.Text))
            {
                if (handler != null)
                {
                    AddUpdateProductHandler(handler);
                }
            }
            else
            {
                MessageBox.Show("Invalid Product code, it should be 5 digits number only, please check and try again");
            }
           
        }

        private void AddUpdateProductHandler(DataChangedEventHandler handler)
        {
            try
            {
                Product product = new Product();
                product.ProductCode = Convert.ToInt32(txtProductCode.Text);
                product.ProductDescription = txtProductDescription.Text != null ? txtProductDescription.Text : "";
                product.RetailPriceIncVAT = Convert.ToDecimal(RetailPriceIncVAT.Text);
                product.VATRate = Convert.ToDecimal(txtVATRate.Text);
                product.Barcodes = txtBarcode.Text != null ? txtBarcode.Text : "";
                handler(product, new EventArgs());
            }
            catch (Exception)
            {

                // ToDo
                // Add validation in decimal fields to take numbers input only
                MessageBox.Show("ToDo: Add validation in decimal fields to take numbers input only.");
            }
              
        }
    }
}
