using CSVDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSVApplication.Interfaces
{
    public interface ICSVLoad
    {
        IList<Product> ReadCSV(string fileName);
    }
}
