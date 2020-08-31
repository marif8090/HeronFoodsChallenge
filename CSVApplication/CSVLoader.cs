using CSVApplication.Interfaces;
using CSVDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSVApplication
{
        public class CSVLoader : ICSVLoad
        {

           public IList<Product> ReadCSV(string fileName)
            {
                // TODO: Error checking.
                string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));
                return lines.Skip(1).Select(line =>
                {
                    string[] data = line.Split(',');
                    return new Product(Convert.ToInt32(data[0]), data[1].ToString(), Convert.ToDecimal(data[2]), Convert.ToDecimal(data[3]), data[4].ToString());
                }).ToList();
            }
        }
}
