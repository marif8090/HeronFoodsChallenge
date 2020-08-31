using CSVApplication.Interfaces;
using CSVDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVApplication.Features
{
  public class SaveCSVFile : ICSVOperation
    {
        public bool SaveCSV(IList<Product> products, string filePath)
        {
            bool isFileSaved;
            
            var csv = AddCSVHeader();
            try
            {
                foreach (var item in products)
                {
                    int ProductCode = item.ProductCode;
                    string ProductDescription = item.ProductDescription;
                    decimal RetailPriceIncVAT = item.RetailPriceIncVAT;
                    decimal VATRate = item.VATRate;
                    string Barcodes = item.Barcodes;

                    var newLine = string.Format("{0},{1},{2},{3},{4}", ProductCode, ProductDescription, RetailPriceIncVAT, VATRate, Barcodes);
                    csv.AppendLine(newLine);
                }
                if (filePath.ToLower().Contains(".csv") == false)
                {
                    filePath = filePath + ".csv";
                }
                File.WriteAllText(filePath, csv.ToString());
                isFileSaved = true;
            }
            catch (IOException)
            {
                isFileSaved = false;
            }
            return isFileSaved;
        }

        private StringBuilder AddCSVHeader()
        {
            var csv = new StringBuilder();
            var newLine = string.Format("{0},{1},{2},{3},{4}", "ProductCode", "ProductDescription", "RetailPriceIncVAT", "VATRate", "Barcodes");
            csv.AppendLine(newLine);
            return csv;
        }
    }
}
