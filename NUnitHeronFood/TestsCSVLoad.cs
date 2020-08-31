using CSVApplication;
using NUnit.Framework;

namespace Tests
{
    public class TestsCSVLoad
    {
        private CSVLoader csvLoader;
        private string filepath;

        [SetUp]
        public void Setup()
        {
            csvLoader = new CSVLoader();
            filepath = @"C:\Users\Arif\Downloads\Coding Challenge\Products.csv";
        }

        [Test]
        public void LoadCSV_TotalCountofList_ShouldBeGreaterThanZero()
        {
           var products = csvLoader.ReadCSV(filepath);
            Assert.Greater(products.Count,0);
        }
    }
}