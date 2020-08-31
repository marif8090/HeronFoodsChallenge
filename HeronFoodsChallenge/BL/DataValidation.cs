using CSVDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronFoodsChallenge.BL
{
    public static class DataValidation
    {
        public static bool IsBarcodeExsit(List<Product> products, Product product)
        {
            bool result=false;

            foreach (var item in products)
            {
                if(item.Barcodes != null)
                {
                    var barcodearray = item.Barcodes.Split('|');
                    for (int i = 0; i < barcodearray.Length; i++)
                    {
                        if(product.Barcodes != null && product.Barcodes !="")
                        {
                            if (product.Barcodes == barcodearray[i] && item.ProductCode != product.ProductCode)
                            {
                                result = true;
                                break;
                            }
                        }
                    }
                }
                
            }

            return result;
        }
        public static bool IsProductCodeExsit(List<Product> products, Product product)
        {
            bool result=false;

            var productfound = products.FirstOrDefault(p => p.ProductCode == product.ProductCode);

            if (productfound != null)
            {
                result = true;
            }
            return result;
        }

        public static bool IsValidProductCode(string productcode)
        {
            bool result = false;

                if (productcode.Length == 5)
                {
                    int validPCode;
                    int.TryParse(productcode, out validPCode);
                    result = validPCode == 0 ? false : true;
                }
                else
                {
                   return result;
                }
   
            return result;
        }

        public static bool IsValidNumber(string value)
        {
            bool result = false;
                int validnumber;
                int.TryParse(value, out validnumber);
                result = validnumber == 0 ? false : true;
            return result;
        }
    }
}
