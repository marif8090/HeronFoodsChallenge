using CSVDataAccess.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVDataAccess.Entities
{
    public class Product : BaseEntityProduct
    {
        public string ProductDescription { get; set; }
        public decimal RetailPriceIncVAT { get; set; }
        public decimal VATRate { get; set; }
        public string Barcodes { get; set; }

        public Product()
        {
        }
        public Product(int ProductCode, string ProductDescription, decimal RetailPriceIncVAT, decimal VATRate, string Barcodes)
        {
            this.ProductCode = ProductCode;
            this.ProductDescription = ProductDescription;
            this.RetailPriceIncVAT = RetailPriceIncVAT;
            this.VATRate = VATRate;
            this.Barcodes = Barcodes;
        }
    }
}
