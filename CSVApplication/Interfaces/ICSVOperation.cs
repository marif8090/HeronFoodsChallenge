using CSVDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVApplication.Interfaces
{
    public interface ICSVOperation
    {
        bool SaveCSV(IList<Product> products, string filePath);
    }
}
