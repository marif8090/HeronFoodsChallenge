using CSVApplication;
using CSVApplication.Features;
using CSVDataAccess.Entities;
using Microsoft.Win32;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NUnitHeronFood
{
    class TestCSVSave
    {
        private List<Product> products;
        private SaveCSVFile csvSaveFile;
        private string filepath;

        [SetUp]
        public void Setup()
        {
            filepath = @"C:\Users\Arif\Downloads\Coding Challenge\NewProducts1.csv";
            csvSaveFile = new SaveCSVFile();
            products = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                Product product1 = new Product();
                product1.ProductCode = i + 9999;
                product1.ProductDescription = "This is a test product: " + i;
                product1.RetailPriceIncVAT = i + 10;
                product1.VATRate = i ;
                product1.Barcodes = "" ;
                products.Add(product1);
            }
        }

        [Test]
        public void SaveCSV_SaveProductsListToFile_ShouldReturnTrue()
        {
            var result = csvSaveFile.SaveCSV(products, filepath);
            Assert.AreEqual(result,true);
        }
    }
}
